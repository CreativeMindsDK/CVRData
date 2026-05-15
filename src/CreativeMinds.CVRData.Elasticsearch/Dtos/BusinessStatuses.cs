using System;

namespace CreativeMinds.CVRData.Elasticsearch.Dtos {

	public static class BusinessStatuses {
		public const String ActiveCompany = "NORMAL";
		public const String ForcedDissolutionInProgress = "UNDER TVANGSOPLØSNING";
		public const String ForciblyDissolved = "TVANGSOPLØST";
		public const String BankruptcyProceedings = "UNDER KONKURS";
		public const String DissolvedFollowingBankruptcy = "OPLØST EFTER KONKURS";
		public const String VoluntarilyDissolved = "OPLØST EFTER ERKLÆRING";
		public const String VoluntaryLiquidationInProgress = "UNDER FRIVILLIG LIKVIDATION";
		public const String DissolvedAfterVoluntaryLiquidation = "OPLØST EFTER FRIVILLIG LIKVIDATION";
		public const String MergedIntoAnotherCompany = "OPLØST EFTER FUSION";
		public const String DeletedFromRegister = "SLETTET";
		public const String NoLegalEffect = "UDEN RETSVIRKNING";
		public const String SplitIntoOtherCompanies = "OPLØST EFTER SPALTNING";
		public const String ReconstructionInProgress = "UNDER REKONSTRUKTION";
		public const String ReassumptionInProgress = "UNDER REASSUMERING";
	}
}
