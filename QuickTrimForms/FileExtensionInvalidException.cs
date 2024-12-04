
namespace QuickTrimForms {
    [Serializable]
    internal class FileExtensionInvalidException : Exception {
        public FileExtensionInvalidException() {
        }

        public FileExtensionInvalidException(string? message) : base(message) {
        }

        public FileExtensionInvalidException(string? message, Exception? innerException) : base(message, innerException) {
        }
    }
}