using boxpoker.network.Core;
using boxpoker.pix.Requests;
using boxpoker.pix.Response;
using boxpoker.pix.Responses;
//using boxpoker.storage.Manager;

using MongoDB.Bson;

namespace boxpoker.pix.Repository
{
    public static class PixRepository
	{
        public static async Task<DynamicQRCodeResponse?> CreateDynamicQRCode(PixDynamicQrCodeRequest request) {
          
            var manager = HttpHelperManager.Instance.HttpHelper;

            if (manager != null)
            {
                var response = await manager.Request<DynamicQRCodeResponse>(request);

                if (response != null)
                {
                   // BoxPokerStorageManager.Instance?.BoxPokerQrCodeCollection.Save(response.ToBsonDocument());
                }
                return response;
            }
            return null;
        }

        public static async Task<DeleteQrCodeResponse?> DeleteDynamicQRCode(int transactionId)
        {
            var request = new DeleteQrCodeRequest(transactionId);

            var manager = HttpHelperManager.Instance.HttpHelper;

            if (manager != null)
            {
                return await manager.Request<DeleteQrCodeResponse>(request);
            }

            return null;     
        }

        public static async Task<PixKeyInformationResponse?> GetPixKeyInfomation(PixKeyInformationRequest request)
        {

            var manager = HttpHelperManager.Instance.HttpHelper;

            if (manager != null)
            {
                var response = await manager.Request<PixKeyInformationResponse>(request);

                if (response != null)
                {
                    //BoxPokerStorageManager.Instance?.BoxPokerPixKeyCollection.Save(response.ToBsonDocument());
                }
                return response;
            }
            return null;
        }

        public static async Task<PaymentTransferResponse?> CreatePaymentTransfer(PaymentTransferRequest request)
        {

            var manager = HttpHelperManager.Instance.HttpHelper;

            if (manager != null)
            {
                var response = await manager.Request<PaymentTransferResponse>(request);

                if (response != null)
                {
                   // BoxPokerStorageManager.Instance?.BoxPokerPixPaymentCollection.Save(response.ToBsonDocument());
                }
                return response;
            }
            return null;
        }

        public static async Task<PixTransactionsStatusResponse?> GetPixTransactionStatus(PixTransactionStatusRequest request)
        {

            var manager = HttpHelperManager.Instance.HttpHelper;

            if (manager != null)
            {
                var response = await manager.Request<PixTransactionsStatusResponse>(request);
                return response;
            }
            return null;
        }
    }
}