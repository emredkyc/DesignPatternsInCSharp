/* In this example, IRenderer acts as the implementor interface in the Bridge pattern, 
 * with HtmlRenderer and PdfRenderer serving as concrete implementations. 
 * The Document class represents the abstraction, and ReportDocument is a 
 * refined abstraction that uses an IRenderer for rendering. 
 * This setup allows the rendering logic to vary independently 
 * from the document's structure, demonstrating the Bridge pattern's 
 * ability to separate abstraction from implementation. */

var htmlRenderer = new HtmlRenderer();
var pdfRenderer = new PdfRenderer();

Document htmlDocument = new ReportDocument(htmlRenderer, "Report Title", "Report Body", "Report Footer");
Console.WriteLine(htmlDocument.Render());

Document pdfDocument = new ReportDocument(pdfRenderer, "Report Title", "Report Body", "Report Footer");
Console.WriteLine(pdfDocument.Render());
