﻿using Nest;
using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos.ProductionUnits {

	public class ParticipantEntity {
		[Number(Name = "enhedsNummer")]
		public Int64 Id { get; set; }
		[Text(Name = "enhedstype")]
		public String Type { get; set; }
		[Number(Name = "forretningsnoegle")]
		public Int64? BusinessKey { get; set; }
		[Date(Name = "sidstIndlaest", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastChanged { get; set; }
		[Date(Name = "sidstOpdateret", Format = "yyyy-MM-ddTHH:mm:ss.fffzzzzz")]
		public DateTime? LastUpdated { get; set; }
		[Nested(Name = "navne")]
		public NameEntity[] Names { get; set; }
		[Boolean(Name = "adresseHemmelig")]
		public Boolean? SecretAddress { get; set; }
		[Boolean(Name = "adresseHemmeligUndtagelse")]
		public Boolean? SecretAddressException { get; set; }
		[Boolean(Name = "adresseHemmeligUndtagelse")]
		public Boolean? AddressUpdateEnded { get; set; }
		[Nested(Name = "beliggenhedsadresse")]
		public LocationEntity[] Location { get; set; }
		[Nested(Name = "organisationer")]
		public OrganisationEntity[] Organisations { get; set; }
	}
}
