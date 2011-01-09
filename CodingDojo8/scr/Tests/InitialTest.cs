using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class InitialTest
    {

        [Test]
        public void TestFIzzBuzz()
        {
            //arrange
            var ergebnis = new List<string>
                               {
                                                                      "1",
                                   "2",
                                   "fizz",
                                   "4",
                                   "buzz",
                                   "fizz",
                                   "7",
                                   "8",
                                   "fizz",
                                   "buzz",
                                   "11",
                                   "fizz",
                                   "13",
                                   "14",
                                   "fizzbuzz"
                               };
            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(1, 15, 3, 5));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));

        }

        //151 152 fizz 154 buzz fizz 157 158 fizz buzz 161 fizz 163 164 fizzbuzz 166 167 fizz 169 buzz fizz 172 173 fizz buzz 176 fizz 178 179 fizzbuzz


        [Test]
        public void TestVariableBoundaries()
        {
            //arrange
            var ergebnis = "4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz".Split(' ');

            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(4, 20, 3, 5));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));

        }

        [Test]
        public void TestVariableCustomerData()
        {
            //arrange
            var ergebnis = "151 152 fizz 154 buzz fizz 157 158 fizz buzz 161 fizz 163 164 fizzbuzz 166 167 fizz 169 buzz fizz 172 173 fizz buzz 176 fizz 178 179 fizzbuzz".Split(' ');

            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(151, 180, 3, 5));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));

        }

        [Test]
        public void TestFIzzBuzz100()
        {
            //arrange
            var ergebnis = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz fizz 22 23 fizz buzz 26 fizz 28 29 fizzbuzz 31 32 fizz 34 buzz fizz 37 38 fizz buzz 41 fizz 43 44 fizzbuzz 46 47 fizz 49 buzz fizz 52 53 fizz buzz 56 fizz 58 59 fizzbuzz 61 62 fizz 64 buzz fizz 67 68 fizz buzz 71 fizz 73 74 fizzbuzz 76 77 fizz 79 buzz fizz 82 83 fizz buzz 86 fizz 88 89 fizzbuzz 91 92 fizz 94 buzz fizz 97 98 fizz buzz".Split(' '); 

            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(1, 100, 3, 5));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));

        }

        [Test]
        public void TestVariablesFizz()
        {
            //Arr
            var ergebnis =
                "1 2 3 4 buzz 6 fizz 8 9 buzz 11 12 13 fizz buzz 16 17 18 19 buzz fizz 22 23 24 buzz 26 27 fizz 29 buzz 31 32 33 34 fizzbuzz 36 37 38 39 buzz 41 fizz 43 44 buzz 46 47 48 fizz buzz 51 52 53 54 buzz fizz 57 58 59 buzz 61 62 fizz 64 buzz 66 67 68 69 fizzbuzz 71 72 73 74 buzz 76 fizz 78 79 buzz 81 82 83 fizz buzz 86 87 88 89 buzz fizz 92 93 94 buzz 96 97 fizz 99 buzz"
                    .Split(' ');
            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(1, 100, 7, 5));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));
        }

        [Test]
        public void TestVariablesFizzBuzz()
        {
            //Arr
            var ergebnis ="1 2 3 4 fizz 6 buzz 8 9 fizz 11 12 13 buzz fizz 16 17 18 19 fizz buzz 22 23 24 fizz 26 27 buzz 29 fizz 31 32 33 34 fizzbuzz 36 37 38 39 fizz 41 buzz 43 44 fizz 46 47 48 buzz fizz 51 52 53 54 fizz buzz 57 58 59 fizz 61 62 buzz 64 fizz 66 67 68 69 fizzbuzz 71 72 73 74 fizz 76 buzz 78 79 fizz 81 82 83 buzz fizz 86 87 88 89 fizz buzz 92 93 94 fizz 96 97 buzz 99 fizz".Split(' ');

            //act
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetList(new FizzBuzz.FizzBuzzParameters(1, 100, 5, 7));

            //assert
            Assert.IsTrue(result.SequenceEqual(ergebnis));
        }
    }

    public class FizzBuzz
    {
        public class FizzBuzzParameters
        {
            private int _lowerBoundary;
            private int _upperBoundary;
            private int _fizzValue;
            private int _buzzValue;

            public FizzBuzzParameters(int lowerBoundary, int upperBoundary, int fizzValue, int buzzValue)
            {
                _lowerBoundary = lowerBoundary;
                _upperBoundary = upperBoundary;
                _fizzValue = fizzValue;
                _buzzValue = buzzValue;
            }

            public int LowerBoundary
            {
                get { return _lowerBoundary; }
            }

            public int UpperBoundary
            {
                get { return _upperBoundary; }
            }

            public int FizzValue
            {
                get { return _fizzValue; }
            }

            public int BuzzValue
            {
                get { return _buzzValue; }
            }
        }

        public IEnumerable<string> GetList(FizzBuzzParameters fizzBuzzParameters)
        {
            for (int i = fizzBuzzParameters.LowerBoundary; i <= fizzBuzzParameters.UpperBoundary ; i++)
            {
                if (Fizz(i,fizzBuzzParameters.FizzValue ) && Buzz(i,fizzBuzzParameters.BuzzValue))
                {
                    yield return "fizzbuzz";
                }
                else if (Fizz(i,fizzBuzzParameters.FizzValue))
                {
                    yield return "fizz";
                }
                else if (Buzz(i,fizzBuzzParameters.BuzzValue))
                {
                    yield return "buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }

        private bool Buzz(int i, int buzzValue)
        {
            return i%buzzValue == 0;
        }

        private bool Fizz(int i, int fizzValue)
        {
            return i % fizzValue  == 0;
        }


    }
}
