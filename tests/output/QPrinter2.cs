// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Wrappers {
    using System;
    using System.Runtime.InteropServices;
    using Mono.VisualC.Interop;
    
    public class QPrinter : QPaintDevice {
        private static IQPrinter impl = Wrappers.Libs.Lib.GetClass <IQPrinter, _QPrinter, QPrinter>("QPrinter");
        public QPrinter(PrinterMode mode) {
            impl.QPrinter(this.Native, mode);
        }
        public QPrinter(QPrinterInfo printer, PrinterMode mode) {
            impl.QPrinter(this.Native, printer, mode);
        }
        public OutputFormat OutputFormat {
            get {
                return impl.outputFormat(this.Native);
            }
            set {
                impl.setOutputFormat(this.Native, value);
            }
        }
        public QString PrinterName {
            get {
                return impl.printerName(this.Native);
            }
            set {
                impl.setPrinterName(this.Native, value);
            }
        }
        public bool IsValid {
            get {
                return impl.isValid(this.Native);
            }
        }
        public QString OutputFileName {
            get {
                return impl.outputFileName(this.Native);
            }
            set {
                impl.setOutputFileName(this.Native, value);
            }
        }
        public QString PrintProgram {
            get {
                return impl.printProgram(this.Native);
            }
            set {
                impl.setPrintProgram(this.Native, value);
            }
        }
        public QString DocName {
            get {
                return impl.docName(this.Native);
            }
            set {
                impl.setDocName(this.Native, value);
            }
        }
        public QString Creator {
            get {
                return impl.creator(this.Native);
            }
            set {
                impl.setCreator(this.Native, value);
            }
        }
        public Orientation Orientation {
            get {
                return impl.orientation(this.Native);
            }
            set {
                impl.setOrientation(this.Native, value);
            }
        }
        public PageSize PageSize {
            get {
                return impl.pageSize(this.Native);
            }
            set {
                impl.setPageSize(this.Native, value);
            }
        }
        public PageOrder PageOrder {
            get {
                return impl.pageOrder(this.Native);
            }
            set {
                impl.setPageOrder(this.Native, value);
            }
        }
        public int Resolution {
            get {
                return impl.resolution(this.Native);
            }
            set {
                impl.setResolution(this.Native, value);
            }
        }
        public ColorMode ColorMode {
            get {
                return impl.colorMode(this.Native);
            }
            set {
                impl.setColorMode(this.Native, value);
            }
        }
        public bool CollateCopies {
            get {
                return impl.collateCopies(this.Native);
            }
            set {
                impl.setCollateCopies(this.Native, value);
            }
        }
        public bool FullPage {
            get {
                return impl.fullPage(this.Native);
            }
            set {
                impl.setFullPage(this.Native, value);
            }
        }
        public int NumCopies {
            get {
                return impl.numCopies(this.Native);
            }
            set {
                impl.setNumCopies(this.Native, value);
            }
        }
        public int ActualNumCopies {
            get {
                return impl.actualNumCopies(this.Native);
            }
        }
        public PaperSource PaperSource {
            get {
                return impl.paperSource(this.Native);
            }
            set {
                impl.setPaperSource(this.Native, value);
            }
        }
        public DuplexMode Duplex {
            get {
                return impl.duplex(this.Native);
            }
            set {
                impl.setDuplex(this.Native, value);
            }
        }
        public QList<System.Int32> SupportedResolutions {
            get {
                return impl.supportedResolutions(this.Native);
            }
        }
        public bool FontEmbeddingEnabled {
            get {
                return impl.fontEmbeddingEnabled(this.Native);
            }
            set {
                impl.setFontEmbeddingEnabled(this.Native, value);
            }
        }
        public bool DoubleSidedPrinting {
            get {
                return impl.doubleSidedPrinting(this.Native);
            }
            set {
                impl.setDoubleSidedPrinting(this.Native, value);
            }
        }
        public QString PrinterSelectionOption {
            get {
                return impl.printerSelectionOption(this.Native);
            }
            set {
                impl.setPrinterSelectionOption(this.Native, value);
            }
        }
        public PrinterState PrinterState {
            get {
                return impl.printerState(this.Native);
            }
        }
        public QPrintEngine PrintEngine {
            get {
                return impl.printEngine(this.Native);
            }
        }
        public int FromPage {
            get {
                return impl.fromPage(this.Native);
            }
        }
        public int ToPage {
            get {
                return impl.toPage(this.Native);
            }
        }
        public PrintRange PrintRange {
            get {
                return impl.printRange(this.Native);
            }
            set {
                impl.setPrintRange(this.Native, value);
            }
        }
        public override void Dispose() {
        }
        public void SetPaperSize(PageSize arg0) {
            impl.setPaperSize(this.Native, arg0);
        }
        public PageSize PaperSize() {
            return impl.paperSize(this.Native);
        }
        public void SetPaperSize(QSizeF paperSize, Unit unit) {
            impl.setPaperSize(this.Native, paperSize, unit);
        }
        public QSizeF PaperSize(Unit unit) {
            return impl.paperSize(this.Native, unit);
        }
        public QRect PaperRect() {
            return impl.paperRect(this.Native);
        }
        public QRect PageRect() {
            return impl.pageRect(this.Native);
        }
        public QRectF PaperRect(Unit arg0) {
            return impl.paperRect(this.Native, arg0);
        }
        public QRectF PageRect(Unit arg0) {
            return impl.pageRect(this.Native, arg0);
        }
        public bool NewPage() {
            return impl.newPage(this.Native);
        }
        public bool Abort() {
            return impl.abort(this.Native);
        }
        public void SetFromTo(int fromPage, int toPage) {
            impl.setFromTo(this.Native, fromPage, toPage);
        }
        public void SetPageMargins(double left, double top, double right, double bottom, Unit unit) {
            impl.setPageMargins(this.Native, left, top, right, bottom, unit);
        }
        public void GetPageMargins(ref double left, ref double top, ref double right, ref double bottom, Unit unit) {
            impl.getPageMargins(this.Native, ref  left, ref  top, ref  right, ref  bottom, unit);
        }
        public interface IQPrinter : ICppClassOverridable<QPrinter> {
            [Constructor()]
            void QPrinter(CppInstancePtr @this, [MangleAs("enum PrinterMode")] PrinterMode mode);
            [Constructor()]
            void QPrinter(CppInstancePtr @this, [MangleAs("class QPrinterInfo const &")] QPrinterInfo printer, [MangleAs("enum PrinterMode")] PrinterMode mode);
            [Virtual()]
            [Destructor()]
            void Destruct(CppInstancePtr @this);
            [Const()]
            OutputFormat outputFormat(CppInstancePtr @this);
            void setOutputFormat(CppInstancePtr @this, [MangleAs("enum OutputFormat")] OutputFormat value);
            [Const()]
            QString printerName(CppInstancePtr @this);
            void setPrinterName(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            [Const()]
            bool isValid(CppInstancePtr @this);
            [Const()]
            QString outputFileName(CppInstancePtr @this);
            void setOutputFileName(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            [Const()]
            QString printProgram(CppInstancePtr @this);
            void setPrintProgram(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            [Const()]
            QString docName(CppInstancePtr @this);
            void setDocName(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            [Const()]
            QString creator(CppInstancePtr @this);
            void setCreator(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            [Const()]
            Orientation orientation(CppInstancePtr @this);
            void setOrientation(CppInstancePtr @this, [MangleAs("enum Orientation")] Orientation value);
            [Const()]
            PageSize pageSize(CppInstancePtr @this);
            void setPageSize(CppInstancePtr @this, [MangleAs("enum PageSize")] PageSize value);
            void setPaperSize(CppInstancePtr @this, [MangleAs("enum PageSize")] PageSize arg0);
            [Const()]
            PageSize paperSize(CppInstancePtr @this);
            void setPaperSize(CppInstancePtr @this, [MangleAs("class QSizeF const &")] QSizeF paperSize, [MangleAs("enum Unit")] Unit unit);
            [Const()]
            QSizeF paperSize(CppInstancePtr @this, [MangleAs("enum Unit")] Unit unit);
            [Const()]
            PageOrder pageOrder(CppInstancePtr @this);
            void setPageOrder(CppInstancePtr @this, [MangleAs("enum PageOrder")] PageOrder value);
            [Const()]
            int resolution(CppInstancePtr @this);
            void setResolution(CppInstancePtr @this, [MangleAs("int")] int value);
            [Const()]
            ColorMode colorMode(CppInstancePtr @this);
            void setColorMode(CppInstancePtr @this, [MangleAs("enum ColorMode")] ColorMode value);
            [Const()]
            bool collateCopies(CppInstancePtr @this);
            void setCollateCopies(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            bool fullPage(CppInstancePtr @this);
            void setFullPage(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            int numCopies(CppInstancePtr @this);
            void setNumCopies(CppInstancePtr @this, [MangleAs("int")] int value);
            [Const()]
            int actualNumCopies(CppInstancePtr @this);
            [Const()]
            PaperSource paperSource(CppInstancePtr @this);
            void setPaperSource(CppInstancePtr @this, [MangleAs("enum PaperSource")] PaperSource value);
            [Const()]
            DuplexMode duplex(CppInstancePtr @this);
            void setDuplex(CppInstancePtr @this, [MangleAs("enum DuplexMode")] DuplexMode value);
            [Const()]
            QList<System.Int32> supportedResolutions(CppInstancePtr @this);
            [Const()]
            bool fontEmbeddingEnabled(CppInstancePtr @this);
            void setFontEmbeddingEnabled(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            bool doubleSidedPrinting(CppInstancePtr @this);
            void setDoubleSidedPrinting(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            QRect paperRect(CppInstancePtr @this);
            [Const()]
            QRect pageRect(CppInstancePtr @this);
            [Const()]
            QRectF paperRect(CppInstancePtr @this, [MangleAs("enum Unit")] Unit arg0);
            [Const()]
            QRectF pageRect(CppInstancePtr @this, [MangleAs("enum Unit")] Unit arg0);
            [Const()]
            QString printerSelectionOption(CppInstancePtr @this);
            void setPrinterSelectionOption(CppInstancePtr @this, [MangleAs("class QString const &")] QString value);
            bool newPage(CppInstancePtr @this);
            bool abort(CppInstancePtr @this);
            [Const()]
            PrinterState printerState(CppInstancePtr @this);
            [Const()]
            QPrintEngine printEngine(CppInstancePtr @this);
            void setFromTo(CppInstancePtr @this, [MangleAs("int")] int fromPage, [MangleAs("int")] int toPage);
            [Const()]
            int fromPage(CppInstancePtr @this);
            [Const()]
            int toPage(CppInstancePtr @this);
            [Const()]
            PrintRange printRange(CppInstancePtr @this);
            void setPrintRange(CppInstancePtr @this, [MangleAs("enum PrintRange")] PrintRange value);
            void setPageMargins(CppInstancePtr @this, [MangleAs("double")] double left, [MangleAs("double")] double top, [MangleAs("double")] double right, [MangleAs("double")] double bottom, [MangleAs("enum Unit")] Unit unit);
            [Const()]
            void getPageMargins(CppInstancePtr @this, [MangleAs("double *")] ref double left, [MangleAs("double *")] ref double top, [MangleAs("double *")] ref double right, [MangleAs("double *")] ref double bottom, [MangleAs("enum Unit")] Unit unit);
        }
        private struct _QPrinter {
            // FIXME: Unknown type "class QScopedPointer <QPrinterPrivate, QScopedPointerDeleter <QPrinterPrivate>>" for field "d_ptr." Assuming IntPtr.
            private System.IntPtr d_ptr;
        }
    }
}