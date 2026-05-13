namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public enum BusinessTypeCodes {
		/// <summary>
		/// Enkeltmandsvirksomhed - Sole proprietorship
		/// </summary>
		ENK = 10,
		/// <summary>
		/// Personligt ejet Mindre Virksomhed - Personally owned small business
		/// </summary>
		PMV = 15,
		/// <summary>
		/// Dødsbo - Estate
		/// </summary>
		DØD = 20,
		/// <summary>
		/// Interessentskab - Partnership
		/// </summary>
		IS = 30,
		/// <summary>
		/// Kommanditselskab - Limited partnership
		/// </summary>
		KS = 40,
		/// <summary>
		/// Medarbejderinvesteringsselskab - Employee investment company
		/// </summary>
		MSS = 45,
		/// <summary>
		/// Partrederi - Ship partnership
		/// </summary>
		PAR = 50,
		/// <summary>
		/// A/S
		/// </summary>
		AS = 60,
		/// <summary>
		/// Kommanditaktieselskab/Partnerselskab - Limited partnership company
		/// </summary>
		KAS = 70,
		/// <summary>
		/// Anpartsselskab
		/// </summary>
		ApS = 80,
		/// <summary>
		/// Iværksætterselskab
		/// </summary>
		IVS = 81,
		/// <summary>
		/// Fonde og andre selvejende institutioner - Foundations and self-governing institutions
		/// </summary>
		FON = 90,
		/// <summary>
		/// Trust - Trust
		/// </summary>
		TRU = 95,
		/// <summary>
		/// Erhvervsdrivende fond - Commercial foundation
		/// </summary>
		EFO = 100,
		/// <summary>
		/// Forening - Association
		/// </summary>
		FOR = 110,
		/// <summary>
		/// Frivillig forening - Voluntary association
		/// </summary>
		FFO = 115,
		/// <summary>
		/// Andelsselskab (-forening) - Cooperative company
		/// </summary>
		ANS = 130,
		/// <summary>
		/// Andelsselskab med begrænset ansvar - Cooperative with limited liability
		/// </summary>
		ABA = 140,
		/// <summary>
		/// Forening eller selskab med begrænset ansvar - Association or company with limited liability
		/// </summary>
		FBA = 150,
		/// <summary>
		/// Selskab med begrænset ansvar - Company with limited liability
		/// </summary>
		SMA = 151,
		/// <summary>
		/// Forening med begrænset ansvar - Association with limited liability
		/// </summary>
		FMA = 152,
		/// <summary>
		/// Europæisk Økonomisk Firmagruppe - European Economic Interest Grouping
		/// </summary>
		EØF = 160,
		/// <summary>
		/// Filial af udenlandsk aktieselskab - Branch of foreign stock company
		/// </summary>
		FAS = 170,
		/// <summary>
		/// Filial af udenlandsk anpartsselskab - Branch of foreign private company
		/// </summary>
		FAP = 180,
		/// <summary>
		/// Filial af udenlandsk virksomhed med begrænset ansv - Branch of foreign limited liability company
		/// </summary>
		FBUA = 190,
		/// <summary>
		/// SCE-selskab - SCE company
		/// </summary>
		SCE = 195,
		/// <summary>
		/// Anden udenlandsk virksomhed - Other foreign company
		/// </summary>
		UDL = 210,
		/// <summary>
		/// Fast forretningssted af Europæisk økonomisk Firmag - Permanent establishment of EEIG
		/// </summary>
		FEØ = 220,
		/// <summary>
		/// Statslig administrativ enhed - State administrative unit
		/// </summary>
		STA = 230,
		/// <summary>
		/// Selvstændig offentlig virksomhed - Independent public company
		/// </summary>
		SOV = 235,
		/// <summary>
		/// Amtskommune - County
		/// </summary>
		AMT = 240,
		/// <summary>
		/// Region - Region
		/// </summary>
		REG = 245,
		/// <summary>
		/// Primærkommune - Primary municipality
		/// </summary>
		KOM = 250,
		/// <summary>
		/// Folkekirkelige Institutioner - Church institutions
		/// </summary>
		FKI = 260,
		/// <summary>
		/// Enhed under oprettelse i Erhvervsstyrelsen - Unit under establishment
		/// </summary>
		EUO = 270,
		/// <summary>
		/// Øvrige virksomhedsformer - Other company forms
		/// </summary>
		ØVR = 280,
		/// <summary>
		/// Særlig finansiel virksomhed - Special financial business
		/// </summary>
		FIV = 285,
		/// <summary>
		/// SE-selskab - SE company (European Company)
		/// </summary>
		ES = 290,
		/// <summary>
		/// Filial af SE-selskab - Branch of SE company
		/// </summary>
		FES = 291,
		/// <summary>
		/// Grønlandsk afdeling af udenlandsk selskab - Greenlandic division of foreign company
		/// </summary>
		GUS = 520,
		/// <summary>
		/// Uoplyst virksomhedsform - Unknown company form
		/// </summary>
		UDP = 990 
	}
}