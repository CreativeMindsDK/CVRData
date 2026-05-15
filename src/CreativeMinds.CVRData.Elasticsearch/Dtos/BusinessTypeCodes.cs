namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public enum BusinessTypeCodes {
		/// <summary>
		/// Enkeltmandsvirksomhed - Sole proprietorship
		/// </summary>
		SoleProprietorship = 10,
		/// <summary>
		/// Personligt ejet Mindre Virksomhed - Personally owned small business
		/// </summary>
		PersonallyOwnedSmallBusiness = 15,
		/// <summary>
		/// Dødsbo - Estate
		/// </summary>
		Estate = 20,
		/// <summary>
		/// Interessentskab - Partnership
		/// </summary>
		Partnership = 30,
		/// <summary>
		/// Kommanditselskab - Limited partnership
		/// </summary>
		LimitedPartnership = 40,
		/// <summary>
		/// Medarbejderinvesteringsselskab - Employee investment company
		/// </summary>
		EmployeeInvestmentCompany = 45,
		/// <summary>
		/// Partrederi - Ship partnership
		/// </summary>
		ShipPartnership = 50,
		/// <summary>
		/// Aktieselskab - Public limited company
		/// </summary>
		PublicLimitedCompany = 60,
		/// <summary>
		/// Kommanditaktieselskab/Partnerselskab - Limited partnership company
		/// </summary>
		LimitedPartnershipCompany = 70,
		/// <summary>
		/// Anpartsselskab - Private limited company
		/// </summary>
		PrivateLimitedCompany = 80,
		/// <summary>
		/// Iværksætterselskab - Entrepreneur company
		/// </summary>
		EntrepreneurCompany = 81,
		/// <summary>
		/// Fonde og andre selvejende institutioner - Foundations and self-governing institutions
		/// </summary>
		FoundationsAndSelfGoverningInstitutions = 90,
		/// <summary>
		/// Trust - Trust
		/// </summary>
		Trust = 95,
		/// <summary>
		/// Erhvervsdrivende fond - Commercial foundation
		/// </summary>
		CommercialFoundation = 100,
		/// <summary>
		/// Forening - Association
		/// </summary>
		Association = 110,
		/// <summary>
		/// Frivillig forening - Voluntary association
		/// </summary>
		VoluntaryAssociation = 115,
		/// <summary>
		/// Andelsselskab (-forening) - Cooperative company
		/// </summary>
		CooperativeCompany = 130,
		/// <summary>
		/// Andelsselskab med begrænset ansvar - Cooperative with limited liability
		/// </summary>
		CooperativeWithLimitedLiability = 140,
		/// <summary>
		/// Forening eller selskab med begrænset ansvar - Association or company with limited liability
		/// </summary>
		AssociationOrCompanyWithLimitedLiability = 150,
		/// <summary>
		/// Selskab med begrænset ansvar - Company with limited liability
		/// </summary>
		CompanyWithLimitedLiability = 151,
		/// <summary>
		/// Forening med begrænset ansvar - Association with limited liability
		/// </summary>
		AssociationWithLimitedLiability = 152,
		/// <summary>
		/// Europæisk Økonomisk Firmagruppe - European Economic Interest Grouping
		/// </summary>
		EuropeanEconomicInterestGrouping = 160,
		/// <summary>
		/// Filial af udenlandsk aktieselskab - Branch of foreign stock company
		/// </summary>
		BranchOfForeignStockCompany = 170,
		/// <summary>
		/// Filial af udenlandsk anpartsselskab - Branch of foreign private company
		/// </summary>
		BranchOfForeignPrivateCompany = 180,
		/// <summary>
		/// Filial af udenlandsk virksomhed med begrænset ansv - Branch of foreign limited liability company
		/// </summary>
		BranchOfForeignLimitedLiabilityCompany = 190,
		/// <summary>
		/// SCE-selskab - SCE company
		/// </summary>
		SCECompany = 195,
		/// <summary>
		/// Anden udenlandsk virksomhed - Other foreign company
		/// </summary>
		OtherForeignCompany = 210,
		/// <summary>
		/// Fast forretningssted af Europæisk økonomisk Firmag - Permanent establishment of EEIG
		/// </summary>
		PermanentEstablishmentOfEEIG = 220,
		/// <summary>
		/// Statslig administrativ enhed - State administrative unit
		/// </summary>
		StateAdministrativeUnit = 230,
		/// <summary>
		/// Selvstændig offentlig virksomhed - Independent public company
		/// </summary>
		IndependentPublicCompany = 235,
		/// <summary>
		/// Amtskommune - County
		/// </summary>
		County = 240,
		/// <summary>
		/// Region - Region
		/// </summary>
		Region = 245,
		/// <summary>
		/// Primærkommune - Primary municipality
		/// </summary>
		PrimaryMunicipality = 250,
		/// <summary>
		/// Folkekirkelige Institutioner - Church institutions
		/// </summary>
		ChurchInstitutions = 260,
		/// <summary>
		/// Enhed under oprettelse i Erhvervsstyrelsen - Unit under establishment
		/// </summary>
		UnitUnderEstablishment = 270,
		/// <summary>
		/// Øvrige virksomhedsformer - Other company forms
		/// </summary>
		OtherCompanyForms = 280,
		/// <summary>
		/// Særlig finansiel virksomhed - Special financial business
		/// </summary>
		SpecialFinancialBusiness = 285,
		/// <summary>
		/// SE-selskab - SE company (European Company)
		/// </summary>
		SECompany = 290,
		/// <summary>
		/// Filial af SE-selskab - Branch of SE company
		/// </summary>
		BranchOfSECompany = 291,
		/// <summary>
		/// Grønlandsk afdeling af udenlandsk selskab - Greenlandic division of foreign company
		/// </summary>
		GreenlandicDivisionOfForeignCompany = 520,
		/// <summary>
		/// Uoplyst virksomhedsform - Unknown company form
		/// </summary>
		UnknownCompanyForm = 990,

		ENK = SoleProprietorship,
		APS = PrivateLimitedCompany,
		FFO = VoluntaryAssociation,
		PMV = PersonallyOwnedSmallBusiness,
		IS = Partnership,
		AS = PublicLimitedCompany,
		FOR = Association,
		IVS = EntrepreneurCompany,
		UDL = OtherForeignCompany,
		FON = FoundationsAndSelfGoverningInstitutions,
		EUO = UnitUnderEstablishment,
		ØVR = OtherCompanyForms,
		KS = LimitedPartnership,
		FKI = ChurchInstitutions,
		SMA = CompanyWithLimitedLiability,
		FAS = BranchOfForeignStockCompany,
		KAS = LimitedPartnershipCompany,
		ANS = CooperativeCompany,
		EFO = CommercialFoundation,
		DØD = Estate,
		FAP = BranchOfForeignPrivateCompany,
		UOP = UnknownCompanyForm,
		ABA = CooperativeWithLimitedLiability,
		FMA = AssociationWithLimitedLiability,
		PAR = ShipPartnership,
		STA = StateAdministrativeUnit,
		KOM = PrimaryMunicipality,
		FIV = SpecialFinancialBusiness,
		GUS = GreenlandicDivisionOfForeignCompany,
		FBA = AssociationOrCompanyWithLimitedLiability,
		FBA2 = BranchOfForeignLimitedLiabilityCompany,
		FES = BranchOfSECompany,
		AMT = County,
		ES = SECompany,
		EØF = EuropeanEconomicInterestGrouping,
		SOV = IndependentPublicCompany,
		TRU = Trust,
		REG = Region,
		MSS = EmployeeInvestmentCompany,
		FEØ = PermanentEstablishmentOfEEIG,
		SCE = SCECompany,
	}
}