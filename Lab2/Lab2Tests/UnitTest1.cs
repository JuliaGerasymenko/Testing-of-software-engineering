using System;
using Xunit;

namespace Lab2Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CreateMultipleFlagMin_Error()
        {
            try {
                IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(1, false);
            } catch {
                Console.WriteLine("the number of flags is less then or equal 1");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }
        }
        [Fact]
        public void Test_CheckGetFlagMethod_False_Case1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckGetFlagMethod_True()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.True(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckGetFlagMethod_False_Case2()
        // set all flag except zero index value true
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(3, false);
            multiple_flag_obj.SetFlag(0);
            multiple_flag_obj.SetFlag(1);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckGetFlagMethod_False_Case3()
        // set zero index value true
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(3, false);
            multiple_flag_obj.SetFlag(0);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_SetLengthLessthanLimit_Error()
        // use max assessible value for the type ulong
        {
            try {
                IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(18446744073709551615, false);
            } catch {
                Console.WriteLine("out of range of the type ulong");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }
        }
        [Fact]
        public void Test_SetLengthLessthanLimit_NotError()
        {
            try{
                IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(17179868700, false);
            } catch {
                Console.WriteLine("initialization of the object led to error");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }

        }
        // [Fact]
        //  Integral constant is too large
        // public void Test_SetLengthBiggerthanLimit_Error()
        // // use max assessible value for the type ulong
        // {
        //     try {
        //         IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(18446744073709551616, false);
        //     } catch {
        //         Console.WriteLine("out of range of the type ulong");
                // doesn't work for me
                // Assert.Fail();
                // Assert.True(false);
        //     }
        // }

        [Fact]
        public void Test_CheckSetValue_False_Case1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            multiple_flag_obj.SetFlag(1);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckSetValue_False_Case2()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            multiple_flag_obj.SetFlag(0);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckSetValue_Error_Case1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            try {
                multiple_flag_obj.SetFlag(2);
            } catch {
                Console.WriteLine("Specified argument was out of the range of valid values");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }
        }
        // error CS1503: Argument 1: cannot convert from 'int' to 'ulong'
        // [Fact]
        // public void Test_CheckSetValue_Error_Case3()
        // {
        //     IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
        //     try {
        //         multiple_flag_obj.SetFlag(-2);
        //     } catch {
        //         Console.WriteLine("Specified argument was out of the range of valid values");
        //     }
        // }
        [Fact]
        public void Test_CheckSetValue_True()
        // all flags were true and after SetFlag metod stay true.
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            multiple_flag_obj.SetFlag(0);
            multiple_flag_obj.SetFlag(1);
            Assert.True(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckDisposeMethod_False()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            multiple_flag_obj.Dispose();
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckResetMethod_False()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            multiple_flag_obj.ResetFlag(0);
            Assert.False(multiple_flag_obj.GetFlag());
        }
        [Fact]
        public void Test_CheckObjectsEquality_True_Case1()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj1 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj2 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            Assert.Equal(multiple_flag_obj2, multiple_flag_obj1);
        }
        [Fact]
        public void Test_CheckResetFlag_Error()
        {
            try{
                IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
                multiple_flag_obj.ResetFlag(18000);
            } catch {
                Console.WriteLine("Specified argument was out of the range of valid values");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }
        }
        //  [Fact]
        // public void Test_CheckResetFlag_Error_Case()
        // {
        //     try{
        //         IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
        //         multiple_flag_obj.ResetFlag(-18000);
        //     } catch {
        //         Console.WriteLine("Specified argument was out of the range of valid values");
        //     }
        // }
        [Fact]
        public void Test_CheckSetFlag_Error_Case2()
        {
            try{
                IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
                multiple_flag_obj.SetFlag(18000);
            } catch {
                Console.WriteLine("Specified argument was out of the range of valid values");
                // doesn't work for me
                // Assert.Fail();
                Assert.True(false);
            }
        }
        [Fact]
        public void Test_CheckToStringMethod_True()
        {
            
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            
            Assert.Equal("True", multiple_flag_obj.GetFlag().ToString());
           
        }  
        [Fact]
        public void Test_CheckToStringMethod_False()
        {
            
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            Assert.Equal("False", multiple_flag_obj.GetFlag().ToString());
           
        }
        [Fact]
        public void Test_CheckObjectsEquality_True_Case_2()
        {
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj1 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            IIG.BinaryFlag.MultipleBinaryFlag multiple_flag_obj2 = multiple_flag_obj1;
            Assert.Equal(multiple_flag_obj2, multiple_flag_obj1);
        }   
    }
}
