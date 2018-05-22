﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinch.SDK.Sources
{
    public class SourceSaveOptions
    {
        /// <summary>
        /// The type of payment source to use. Can be either "bank-account" or "credit-card".
        /// </summary>
        public string SourceType { get; set; }
        
        /// <summary>
        /// The Payer's Bank Account Number. Currently must be between 3 and 10 digits long (inclusive). Everything except numbers will be stripped.
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The Payer's BSB (Bank State Branch number). Must be 6 digits. Everything except numbers will be stripped.
        /// </summary>
        public string BankAccountBsb { get; set; }        

        /// <summary>
        /// The Payer's Bank Account Name. If left blank, it will be set to the Payer's name.
        /// </summary>
        public string BankAccountName { get; set; }

        /// <summary>
        /// The Token generated by the Pinch Capture javascript library.
        /// </summary>
        public string CreditCardToken { get; set; }
    }
}