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
	[XmlType("ContactDetails2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.02")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public sealed record ContactDetails2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[XmlElement("NmPrfx")]
		public NamePrefix1Code NmPrfxValue { get; set; }

		/// <summary>
		/// <para xml:lang="en">Gets or sets a value indicating whether the NmPrfx property is specified.</para>
		/// </summary>
		[XmlIgnore]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool NmPrfxValueSpecified { get; set; }

		[XmlIgnore]
		public NamePrefix1Code? NmPrfx
		{
			get
			{
				if (NmPrfxValueSpecified)
				{
					return NmPrfxValue;
				}

				return null;
			}
			set
			{
				NmPrfxValue = value.GetValueOrDefault();
				NmPrfxValueSpecified = value.HasValue;
			}
		}

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 140.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(140)]
		[XmlElement("Nm")]
		public string Nm { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
		/// </summary>
		[RegularExpression("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
		[XmlElement("PhneNb")]
		public string PhneNb { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
		/// </summary>
		[RegularExpression("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
		[XmlElement("MobNb")]
		public string MobNb { get; set; }

		/// <summary>
		/// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
		/// </summary>
		[RegularExpression("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
		[XmlElement("FaxNb")]
		public string FaxNb { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 2048.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(2048)]
		[XmlElement("EmailAdr")]
		public string EmailAdr { get; set; }

		/// <summary>
		/// <para xml:lang="en">Minimum length: 1.</para>
		/// <para xml:lang="en">Maximum length: 35.</para>
		/// </summary>
		[MinLength(1)]
		[MaxLength(35)]
		[XmlElement("Othr")]
		public string Othr { get; set; }
	}
}
