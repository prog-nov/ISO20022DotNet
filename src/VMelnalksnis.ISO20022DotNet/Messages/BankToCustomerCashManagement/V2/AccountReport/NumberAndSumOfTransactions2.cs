﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VMelnalksnis.ISO20022DotNet.Messages.BankToCustomerCashManagement.V2.AccountReport
{
	[GeneratedCode("XmlSchemaClassGenerator", "2.0.565.0")]
	[Serializable]
	[XmlType("NumberAndSumOfTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record NumberAndSumOfTransactions2
	{
		/// <summary>
		/// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
		/// </summary>
		[RegularExpression("[0-9]{1,15}")]
		[XmlElement("NbOfNtries")]
		public string NbOfNtries { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("Sum")]
		public decimal SumValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the Sum property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SumValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? Sum
		{
			get
			{
				if (SumValueSpecified)
				{
					return SumValue;
				}

				return null;
			}
			init
			{
				SumValue = value.GetValueOrDefault();
				SumValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("TtlNetNtryAmt")]
		public decimal TtlNetNtryAmtValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the TtlNetNtryAmt property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TtlNetNtryAmtValueSpecified { get; init; }

		/// <summary>
		/// <para xml:lang="en">Total number of digits in fraction: 17.</para>
		/// <para xml:lang="en">Total number of digits: 18.</para>
		/// </summary>
		[XmlIgnore]
		public decimal? TtlNetNtryAmt
		{
			get
			{
				if (TtlNetNtryAmtValueSpecified)
				{
					return TtlNetNtryAmtValue;
				}

				return null;
			}
			init
			{
				TtlNetNtryAmtValue = value.GetValueOrDefault();
				TtlNetNtryAmtValueSpecified = value.HasValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("CdtDbtInd")]
		public CreditDebitCode CdtDbtIndValue { get; init; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CdtDbtIndValueSpecified { get; init; }

		[XmlIgnore]
		public CreditDebitCode? CdtDbtInd
		{
			get
			{
				if (CdtDbtIndValueSpecified)
				{
					return CdtDbtIndValue;
				}

				return null;
			}
			init
			{
				CdtDbtIndValue = value.GetValueOrDefault();
				CdtDbtIndValueSpecified = value.HasValue;
			}
		}
	}
}
