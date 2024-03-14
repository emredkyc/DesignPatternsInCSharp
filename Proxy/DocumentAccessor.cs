public class DocumentAccessor : IDocumentAccessor
{
    public string FetchDocument(string documentId)
    {
        // Simulate fetching document content. In a real scenario, this would involve database access or API calls.
        return $"Document content for {documentId}.";
    }
}
