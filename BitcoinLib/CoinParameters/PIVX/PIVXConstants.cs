using BitcoinLib.CoinParameters.Base;

namespace BitcoinLib.CoinParameters.PIVX
{
    public static class PIVXConstants
    {
        public sealed class Constants : CoinConstants<Constants>
        {
            public readonly ushort CoinReleaseHalfsEveryXInYears = 7;
            public readonly ushort DifficultyIncreasesEveryXInBlocks = 34560;
            public readonly string Symbol = "PIVX";
        }
    }
}