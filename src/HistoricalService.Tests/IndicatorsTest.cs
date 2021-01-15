using System.Collections.Generic;
using NUnit.Framework;

namespace HistoricalService.Tests {
    public class IndicatorsTest {
        [TestCase(12,
            new[] {
                459.99,
                448.85,
                446.06,
                450.81,
                442.8,
                448.97,
                444.57,
                441.4,
                430.47,
                420.05,
                431.14,
                425.66,
                430.58,
                431.72,
                437.87,
                428.43,
                428.35,
                432.5,
                443.66,
                455.72,
                454.49,
                452.08,
                452.73,
                461.91,
                463.58,
                461.14,
                452.08,
                442.66,
                428.91,
                429.79,
                431.99,
                427.72,
                423.2,
                426.21,
                426.98,
                435.69,
                434.33,
                429.8,
                419.85,
                426.24,
                402.8,
                392.05,
                390.53,
                398.67,
                406.13,
                405.46,
                408.38,
                417.2,
                430.12,
                442.78,
                439.29,
                445.52,
                449.98,
                460.71,
                458.66,
                463.84,
                456.77,
                452.97,
                454.74,
                443.86,
                428.85,
                434.58,
                433.26,
                442.93,
                439.66,
                441.35
            },
            ExpectedResult = new[] {
                440.8975,
                439.3102,
                438.1425,
                438.1006,
                436.6128,
                435.3416,
                434.9044,
                436.2514,
                439.2466,
                441.5917,
                443.2053,
                444.6706,
                447.3229,
                449.8240,
                451.5649,
                451.6441,
                450.2620,
                446.9770,
                444.3329,
                442.4340,
                440.1703,
                437.5595,
                435.8134,
                434.4544,
                434.6445,
                434.5961,
                433.8583,
                431.7031,
                430.8627,
                426.5453,
                421.2384,
                416.5140,
                413.7688,
                412.5936,
                411.4961,
                411.0167,
                411.9680,
                414.7606,
                419.0713,
                422.1818,
                425.7723,
                429.4966,
                434.2987,
                438.0466,
                442.0148,
                444.2848,
                445.6210,
                447.0239,
                446.5372,
                443.8161,
                442.3951,
                440.9897,
                441.2882,
                441.0377,
                441.0858
            })]
        public IEnumerable<double> CalculateTest(int period, double[] values) {
            return default;
        }
    }
}