﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Riskified.NetSDK.Model;

namespace Riskified.Tests
{
    [TestFixture]
    class InputValidatorsTests
    {
        [Test]
        public void ValidateEmail_ValidValueInserted_DoesntThrowException()
        {
            string[] vals = {"tE_s.t@exam-ple.com","t%eS+t@ExaMple.co","t%eS+t@ExaMple.bgua"};

            Validate_ValidValueSet_DoesntThrowException(InputValidators.ValidateEmail, vals);
        }

        [Test]
        public void ValidateEmail_InvalidValueInserted_ThrowsException()
        {
            string[] vals = {"@exam-ple.com", "t%eS+t@.co", "t%eS+t@ExaMple.bguaf"};

            Validate_InvalidValueSet_ThrowsException(InputValidators.ValidateEmail, vals);
        }

        [Test]
        public void ValidateIp_ValidValueInserted_DoesntThrowException()
        {
            string[] vals = {"192.11.2.5", "238.0.0.3", "127.0.0.1"};

            Validate_ValidValueSet_DoesntThrowException(InputValidators.ValidateIp, vals);
        }

        [Test]
        public void ValidateIp_InvalidValueSet_ThrowsException()
        {
            string[] vals = {"127.0..1", "257.1.1.1", "a.0.0.1"};

            Validate_InvalidValueSet_ThrowsException(InputValidators.ValidateIp, vals);
        }

        [Test]
        public void ValidateCountryOrProvinceCode_ValidValueSet_DoesntThrowException()
        {
            string[] vals = {"US","IL","IR"};

            Validate_ValidValueSet_DoesntThrowException(InputValidators.ValidateCountryOrProvinceCode, vals);
        }

        [Test]
        public void ValidateCountryOrProvinceCode_InvalidValueSet_ThrowsException()
        {
            string[] vals = { "USA", "I", "22" };

            Validate_InvalidValueSet_ThrowsException(InputValidators.ValidateCountryOrProvinceCode, vals);
        }

        [Test]
        public void ValidateAvsOrCvvCode_ValidValueSet_DoesntThrowException()
        {
            string[] vals = { "U", "y", "N" };

            Validate_ValidValueSet_DoesntThrowException(InputValidators.ValidateAvsOrCvvResultCode, vals);
        }

        [Test]
        public void ValidateAvsOrCvvCode_InvalidValueSet_ThrowsException()
        {
            string[] vals = { "Paa", "Ii", "22" };

            Validate_InvalidValueSet_ThrowsException(InputValidators.ValidateAvsOrCvvResultCode, vals);
        }

        private void Validate_ValidValueSet_DoesntThrowException(Action<string> validatorToTest, string[] validValues)
        {
            #region setup

            bool exceptionThrown = false;

            #endregion

            #region act

            foreach (var validValue in validValues)
            {
                try
                {
                    validatorToTest(validValue);
                }
                catch (Exception)
                {
                    exceptionThrown = true;
                }
            }

            #endregion

            #region verify

            Assert.False(exceptionThrown);

            #endregion
        }
        
        private void Validate_InvalidValueSet_ThrowsException(Action<string> validatorToTest,string[] invalidValues)
        {
            #region setup

            bool exceptionThrown = true;

            #endregion
            
            #region act

            foreach (var invalidValue in invalidValues)
            {


                try
                {
                    validatorToTest(invalidValue);
                    exceptionThrown = false;
                }
                catch (Exception)
                {
                }
            }

            #endregion

            #region verify

            Assert.True(exceptionThrown);

            #endregion
        }
    }
}
