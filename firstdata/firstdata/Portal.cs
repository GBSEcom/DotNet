using System;
using System.Collections.Generic;

namespace firstdata
{
    public class Portal
    {
        private Config config;
        public Config Config { get => config; }
        public TransactionPortal Transaction;
        //private AccessTokenPortal accessToken;
        //private CertificatePortal certPortal;
        //private WalletDecryptionPortal walletDecryptProtal;

        public Portal(Dictionary<String, String> _config)
        {
            config = new Config(_config);
            Transaction = new TransactionPortal(this);

        }

        public Portal(Config _config)
        {
            config = _config;
            Transaction = new TransactionPortal(this);
        }
    }
}