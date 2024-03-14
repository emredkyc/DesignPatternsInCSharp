/* In this example, the SecureDocumentAccessorProxy acts as a protective proxy. 
 * It enforces access control checks and logs document access attempts, 
 * providing a secure way to manage sensitive information. 
 * This approach is common in systems where security and auditability are crucial, 
 * such as financial, medical, or legal information systems. */

string userId = "user123"; // Simulate a user ID
string documentId = "doc456"; // Simulate a document ID

IDocumentAccessor documentAccessor = new SecureDocumentAccessorProxy(userId);
string? documentContent = documentAccessor.FetchDocument(documentId);

if (documentContent != null)
{
    Console.WriteLine($"Fetched document content: {documentContent}");
}