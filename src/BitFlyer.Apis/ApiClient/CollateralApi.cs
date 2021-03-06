﻿using System.Threading.Tasks;

namespace BitFlyer.Apis
{
    public partial class BitFlyerPrivateApiClient
    {
        private const string CollateralApiPath = "/v1/me/getcollateral";

        public async Task<Collateral> GetCollateral()
        {
            return await Get<Collateral>(CollateralApiPath);
        }
    }
}
