using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte byte_max = byte.MaxValue;
            byte byte_min = byte.MinValue;
            Console.WriteLine($"byte máximo: {byte_max}");
            Console.WriteLine($"byte mínimo: {byte_min}");
            sbyte sbyte_max = sbyte.MaxValue;
            sbyte sbyte_min = sbyte.MinValue;
            Console.WriteLine($"sbyte máximo: {sbyte_max}");
            Console.WriteLine($"sbyte mínimo: {sbyte_min}");
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;
            Console.WriteLine($"short máximo: {maxShort}");
            Console.WriteLine($"short mínimo: {minShort}");
            ushort short_maxUpper = ushort.MaxValue;
            ushort short_minUpper = ushort.MinValue;
            Console.WriteLine($"ushort máximo: {short_maxUpper}");
            Console.WriteLine($"ushort mínimo: {short_minUpper}");
            int int_max = int.MaxValue;
            int int_min = int.MinValue;
            Console.WriteLine($"int máximo: {int_max}");
            Console.WriteLine($"int mínimo: {int_min}");
            uint uint_max = uint.MaxValue;
            uint uint_min = uint.MinValue;
            Console.WriteLine($"uint máximo: {uint_max}");
            Console.WriteLine($"uint mínimo: {uint_min}");
            uint overflow_uintmax = unchecked(uint.MaxValue + 1);
            Console.WriteLine($"uint máximo + 1 overflow: {overflow_uintmax}");
            long long_max = long.MaxValue;
            long long_min = long.MinValue;
            Console.WriteLine($"long máximo: {long_max}");
            Console.WriteLine($"long mínimo: {long_min}");
            ulong ulong_max = ulong.MaxValue;
            ulong ulong_min = ulong.MinValue;
            Console.WriteLine($"ulong máximo: {ulong_max}");
            Console.WriteLine($"ulong mínimo: {ulong_min}");
            char char_max = char.MaxValue;
            char char_min = char.MinValue;
            Console.WriteLine($"char máximo: {char_max}");
            Console.WriteLine($"char mínimo: {char_min}");
            float float_max = float.MaxValue;
            float float_min = float.MinValue;
            Console.WriteLine($"float máximo: {float_max:F3}");
            Console.WriteLine($"float mínimo: {float_min:F3}");
            float overflowFloat = float_max * 50.0f;
            float underflowFloat = float_min / 5000000.0f;
            Console.WriteLine($"float máx * 50.0f overflow: {overflowFloat:F3}");
            Console.WriteLine($"float mínimo / 5000000.0f underflow: {underflowFloat:F3}");
            double double_max = double.MaxValue;
            double double_min = double.MinValue;
            Console.WriteLine($"double máximo: {double_max:F3}");
            Console.WriteLine($"double mínimo: {double_min:F3}");
            decimal decimal_max = decimal.MaxValue;
            decimal decimal_min = decimal.MinValue;
            Console.WriteLine($"decimal máximo: {decimal_max:F3}");
            Console.WriteLine($"decimal mínimo: {decimal_min:F3}");

            float floatminfinite = float.NegativeInfinity;
            float floatmaxinfinite = float.PositiveInfinity;
            float fnan = float.NaN;
            Console.WriteLine($"float mínimo infinito: {floatminfinite}");
            Console.WriteLine($"float máximo infinito: {floatmaxinfinite}");
            Console.WriteLine($"float NaN: {fnan}");

            double dminfinite = double.NegativeInfinity;
            double dmaxinfinite = double.PositiveInfinity;
            double dnan = double.NaN;
            Console.WriteLine($"double mínimo infinito: {dminfinite}");
            Console.WriteLine($"double máximo infinito: {dmaxinfinite}");
            Console.WriteLine($"double NaN: {dnan}");
        }
    }
}
