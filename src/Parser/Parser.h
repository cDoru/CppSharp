/************************************************************************
*
* CppSharp
* Licensed under the simplified BSD license. All rights reserved.
*
************************************************************************/

#include <llvm/Support/Host.h>
#include <clang/Frontend/CompilerInstance.h>
#include <clang/Frontend/CompilerInvocation.h>
#include <clang/Frontend/ASTConsumers.h>
#include <clang/Basic/FileManager.h>
#include <clang/Basic/TargetOptions.h>
#include <clang/Basic/TargetInfo.h>
#include <clang/Basic/IdentifierTable.h>
#include <clang/AST/ASTConsumer.h>
#include <clang/AST/Mangle.h>
#include <clang/AST/RawCommentList.h>
#include <clang/AST/Comment.h>
#include <clang/AST/RecordLayout.h>
#include <clang/AST/VTableBuilder.h>
#include <clang/Lex/Preprocessor.h>
#include <clang/Lex/PreprocessingRecord.h>
#include <clang/Parse/ParseAST.h>
#include <clang/Sema/Sema.h>
#include "CXXABI.h"
#include "Options.h"

#include <string>
typedef std::string String;

namespace clang {
  class TargetCodeGenInfo;
  namespace CodeGen {
    class CodeGenTypes;
  }
}

#define Debug printf

struct Parser
{
    Parser(ParserOptions^ Opts);

    void SetupHeader();
    ParserResult^ ParseHeader(const std::string& File);
    ParserResult^ ParseLibrary(const std::string& File);
    ParserResultKind ParseArchive(llvm::StringRef File,
                                  llvm::MemoryBuffer *Buffer);
    ParserResultKind ParseSharedLib(llvm::StringRef File,
                                    llvm::MemoryBuffer *Buffer);

protected:

    // AST traversers
    void WalkAST();
    void WalkMacros(clang::PreprocessingRecord* PR);
    CppSharp::AST::Declaration^ WalkDeclaration(clang::Decl* D,
        bool IgnoreSystemDecls = true, bool CanBeDefinition = false);
    CppSharp::AST::Declaration^ WalkDeclarationDef(clang::Decl* D);
    CppSharp::AST::Enumeration^ WalkEnum(clang::EnumDecl*);
    CppSharp::AST::Function^ WalkFunction(clang::FunctionDecl*, bool IsDependent = false,
        bool AddToNamespace = true);
    CppSharp::AST::Class^ WalkRecordCXX(clang::CXXRecordDecl*);
    CppSharp::AST::Method^ WalkMethodCXX(clang::CXXMethodDecl*);
    CppSharp::AST::Field^ WalkFieldCXX(clang::FieldDecl*, CppSharp::AST::Class^);
    CppSharp::AST::ClassTemplate^ Parser::WalkClassTemplate(clang::ClassTemplateDecl*);
    CppSharp::AST::FunctionTemplate^ Parser::WalkFunctionTemplate(
        clang::FunctionTemplateDecl*);
    CppSharp::AST::Variable^ WalkVariable(clang::VarDecl*);
    CppSharp::AST::RawComment^ WalkRawComment(const clang::RawComment*);
    CppSharp::AST::Type^ WalkType(clang::QualType, clang::TypeLoc* = 0,
      bool DesugarType = false);
    void WalkVTable(clang::CXXRecordDecl*, CppSharp::AST::Class^);
    CppSharp::AST::VTableLayout^ WalkVTableLayout(const clang::VTableLayout&);
    CppSharp::AST::VTableComponent WalkVTableComponent(const clang::VTableComponent&);

    // Clang helpers
    SourceLocationKind GetLocationKind(const clang::SourceLocation& Loc);
    bool IsValidDeclaration(const clang::SourceLocation& Loc);
    std::string GetDeclMangledName(clang::Decl*, clang::TargetCXXABI,
        bool IsDependent = false);
    std::string GetTypeName(const clang::Type*);
    void HandleComments(clang::Decl* D, CppSharp::AST::Declaration^);
    void WalkFunction(clang::FunctionDecl* FD, CppSharp::AST::Function^ F,
        bool IsDependent = false);
    void HandlePreprocessedEntities(CppSharp::AST::Declaration^ Decl, clang::SourceRange sourceRange,
                                    CppSharp::AST::MacroLocation macroLocation = CppSharp::AST::MacroLocation::Unknown);
    bool GetDeclText(clang::SourceRange, std::string& Text);

    CppSharp::AST::TranslationUnit^ GetTranslationUnit(clang::SourceLocation Loc,
        SourceLocationKind *Kind = 0);
    CppSharp::AST::TranslationUnit^ GetTranslationUnit(const clang::Decl*);

    CppSharp::AST::DeclarationContext^ GetNamespace(clang::Decl*, clang::DeclContext*);
    CppSharp::AST::DeclarationContext^ GetNamespace(clang::Decl*);

    void HandleDiagnostics(ParserResult^ res);

    int Index;
    gcroot<CppSharp::AST::Library^> Lib;
    gcroot<ParserOptions^> Opts;
    llvm::OwningPtr<clang::CompilerInstance> C;
    clang::ASTContext* AST;
    clang::TargetCXXABI::Kind TargetABI;
    clang::TargetCodeGenInfo* CodeGenInfo;
    clang::CodeGen::CodeGenTypes* CodeGenTypes;
};
