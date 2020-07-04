using System;

namespace Challenge_ProgressiveTaxation
{
    internal class Brackets
    {
        public float[][] TaxBrackets   // property
        { get; set; }

        //Basic contructor with pre-determined default informations
        public Brackets()
        {
            Initialize(new float[][] {
                new float[] { 10000f, 30000f, 100000f },
                new float[] { 0f, 0.10f, 0.25f, 0.40f }
            });
        }

        //Made different constructors while thinking how to write the TaxCalculation as seamless as possible.
        public Brackets(float[] bracketStarts, float[] taxRate)
        {
            Initialize(new float[][] { bracketStarts, taxRate });
        }

        public Brackets(float[][] bracketRanges)
        {
            Initialize(bracketRanges);
        }

        private void Initialize(float[][] bracketRanges)
        {
            TaxBrackets = bracketRanges;
        }

        public float TaxCalculation(float income)
        {
            //TaxIndex will determinate which tax rate to apply
            int taxIndex = 0;
            for (int i = 0; i < TaxBrackets.GetLength(0); i++)
            {
                //If the income is supperior to the limit of the tax bracket the index is moved to the next one.
                if (income > TaxBrackets[0][i])
                    taxIndex = i + 1;
            }

            //Retuning the value of tax due based on the income and it's place in the taxation brackets.
            return income * TaxBrackets[1][taxIndex];
        }
    }
}