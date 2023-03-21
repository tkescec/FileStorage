using Azure.Storage.Blobs;
using System;
using System.Configuration;

namespace FileStorage.Dao
{
    static class Repository
    {
        private const string ContainerName = "blobcontainer";
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        private static readonly Lazy<BlobContainerClient> containter = new Lazy<BlobContainerClient>(() => new BlobServiceClient(connectionString).GetBlobContainerClient(ContainerName));
        public static BlobContainerClient Container => containter.Value;

    }
}
