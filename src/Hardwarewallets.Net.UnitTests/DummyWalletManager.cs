﻿using Hardwarewallets.Net.Base;
using System;
using System.Threading.Tasks;

namespace Hardwarewallets.Net
{
    public class DummyWalletManager : IHardwarewalletManager
    {
        public async Task<string> GetAddressAsync(IAddressPath addressPath, bool display)
        {
            switch (addressPath.CoinType)
            {
                case 0:
                    return "1EdcJ3XAZ1jMHka8kwD6oyMkHuJC5qVu8p";
                case 60:
                    return "0x3f2dD9850509367b57C900F7e1C5f4F0bfF1014B";
                default:
                    throw new NotImplementedException();
            }
        }

        public async Task<string> GetPublicKeyAsync(IAddressPath addressPath, bool display)
        {
            switch (addressPath.CoinType)
            {
                case 0:
                    return "02a1633cafcc01ebfb6d78e39f687a1f0995c62fc95f51ead10a02ee0be551b5dc";
                case 60:
                    return "0x3f2dD9850509367b57C900F7e1C5f4F0bfF1014Bf4F0bfF1014B";
                default:
                    throw new NotImplementedException();
            }
        }

        public async Task<byte[]> SignTransaction<T>(T transaction) where T : ITransaction
        {
            return new byte[0];
        }
    }
}