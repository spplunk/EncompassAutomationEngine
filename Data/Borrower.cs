﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Borrower
    {
        public string firstNameWithMiddleName { get; set; }
        public string lastNameWithSuffix { get; set; }
        public int? ageAtApplicationYearsCount { get; set; }
        public int? schoolingTermYears { get; set; }
        public string maritalStatusType { get; set; }
        public int? dependentCount { get; set; }
        public string dependentsAgesDescription { get; set; }
        public string experianCreditScore { get; set; }
        public string taxIdentificationIdentifier { get; set; }
        public string homePhoneNumber { get; set; }
        public decimal? otherSumAmount { get; set; }
        public bool? outstandingJudgementsIndicator { get; set; }
        public bool? propertyForeclosedPastSevenYearsIndicator { get; set; }
        public bool? coMakerEndorserOfNoteIndicator { get; set; }
        public bool? partyToLawsuitIndicator { get; set; }
        public bool? alimonyChildSupportObligationIndicator { get; set; }
        public bool? borrowedDownPaymentIndicator { get; set; }
        public bool? hmdaRefusalIndicator { get; set; }
        public bool? bankruptcyIndicator { get; set; }
        public bool? homeownerPastThreeYearsIndicator { get; set; }
        public bool? intentToOccupyIndicator { get; set; }
        public bool? presentlyDelinquentIndicator { get; set; }
        public bool? declarationsKIndicator { get; set; }
        public string hmda2003RaceNationalOriginType { get; set; }
        public string hmdaGenderType { get; set; }
        public decimal? totalLiabilitiesBalanceAmount { get; set; }
        public decimal? totalPresentHousingExpenseAmount { get; set; }
        public decimal? totalMonthlyIncomeMinusNetRentalAmount { get; set; }
        public decimal? subtotalLiquidAssetsMinusGiftAmount { get; set; }
        public string lpdGsa { get; set; }
        public bool? declarationsJIndicator { get; set; }
        public string priorPropertyUsageType { get; set; }
        public string caivrsIdentifier { get; set; }
        public bool? loanForeclosureOrJudgementIndicator { get; set; }
        public string priorPropertyTitleType { get; set; }
        public decimal? baseMonthlyIncomeAmount { get; set; }
        public string hmda2003OtherRaceNationalOriginDescription { get; set; }
        public decimal? otherMonthlyIncomeAmount { get; set; }
        public decimal? vaFederalTaxAmount { get; set; }
        public decimal? vaStateTaxAmount { get; set; }
        public decimal? vaRetirementAmount { get; set; }
        public decimal? positiveCashFlow { get; set; }
        public string workEmailAddress { get; set; }
        public string personFaxNumber { get; set; }
        public string emailAddressText { get; set; }
        public decimal? vaOtherAmount { get; set; }
        public decimal? vaTotalIncomeDeductionsAmount { get; set; }
        public decimal? vaNetTakeHomePayAmount { get; set; }
        public decimal? vaOtherNetIncomeAmount { get; set; }
        public decimal? vaTotalNetIncomeAmount { get; set; }
        public DateTime? birthDate { get; set; }
        public string equifaxScore { get; set; }
        public string transUnionScore { get; set; }
        public string mobilePhone { get; set; }
        public string minFicoScore { get; set; }
        public string hmdaEthnicityType { get; set; }
        public bool? hmdaAmericanIndianIndicator { get; set; }
        public bool? hmdaAsianIndicator { get; set; }
        public bool? hmdaAfricanAmericanIndicator { get; set; }
        public bool? hmdaPacificIslanderIndicator { get; set; }
        public bool? hmdaWhiteIndicator { get; set; }
        public bool? hmdaNotProvidedIndicator { get; set; }
        public bool? hmdaNotApplicableIndicator { get; set; }
        public decimal? totalMonthlyIncomeAmount { get; set; }
        public decimal? userDefinedIncome { get; set; }
        public bool? mailingAddressSameAsPresentIndicator { get; set; }
        public string fullNameWithSuffix { get; set; }
        public string aliasName { get; set; }
        public string powerOfAttorneyName { get; set; }
        public string borrowerType { get; set; }
        public string powerOfAttorneyTitleDescription { get; set; }
        public int? experian30Days { get; set; }
        public int? experian60Days { get; set; }
        public int? experian90Days { get; set; }
        public int? experian120Days { get; set; }
        public int? transUnion30Days { get; set; }
        public int? transUnion60Days { get; set; }
        public int? transUnion90Days { get; set; }
        public int? transUnion120Days { get; set; }
        public int? equifax30Days { get; set; }
        public int? equifax60Days { get; set; }
        public int? equifax90Days { get; set; }
        public int? equifax120Days { get; set; }
        public DateTime? creditReceivedDate { get; set; }
        public bool? priorForeclosure { get; set; }
        public DateTime? dateOfBankruptcy { get; set; }
        public DateTime? dateOfForeclosure { get; set; }
        public string citizenshipResidencyType { get; set; }
        public string nearestRelativeAddress { get; set; }
        public string nearestRelativeCity { get; set; }
        public string nearestRelativeState { get; set; }
        public string bankAccountType { get; set; }
        public string bankContactName { get; set; }
        public string bankAccountNumber { get; set; }
        public string bankContactAddress { get; set; }
        public string bankContactCity { get; set; }
        public string bankContactState { get; set; }
        public string bankContactPostalCode { get; set; }
        public string nearestRelativePostalCode { get; set; }
        public string nearestRelativeRelationship { get; set; }
        public string nearestRelativePhone { get; set; }
        public string nearestRelativeName { get; set; }
        public string freddieMacPerson1 { get; set; }
        public string freddieMacPerson2 { get; set; }
        public DateTime? experianDatePulled { get; set; }
        public string experianKeyFactor1 { get; set; }
        public string experianKeyFactor2 { get; set; }
        public string experianKeyFactor3 { get; set; }
        public string experianKeyFactor4 { get; set; }
        public string experianKeyFactor5 { get; set; }
        public string transUnionKeyFactor5 { get; set; }
        public string equifaxKeyFactor5 { get; set; }
        public DateTime? transUnionDatePulled { get; set; }
        public string transUnionKeyFactor1 { get; set; }
        public string transUnionKeyFactor2 { get; set; }
        public string transUnionKeyFactor3 { get; set; }
        public string transUnionKeyFactor4 { get; set; }
        public DateTime? equifaxDatePulled { get; set; }
        public string equifaxKeyFactor1 { get; set; }
        public string equifaxKeyFactor2 { get; set; }
        public string equifaxKeyFactor3 { get; set; }
        public string equifaxKeyFactor4 { get; set; }
        public string experianFactorCode1 { get; set; }
        public string experianFactorCode2 { get; set; }
        public string experianFactorCode3 { get; set; }
        public string experianFactorCode4 { get; set; }
        public string experianFactorCode5 { get; set; }
        public string transUnionFactorCode1 { get; set; }
        public string transUnionFactorCode2 { get; set; }
        public string transUnionFactorCode3 { get; set; }
        public string transUnionFactorCode4 { get; set; }
        public string transUnionFactorCode5 { get; set; }
        public string equifaxFactorCode1 { get; set; }
        public string equifaxFactorCode2 { get; set; }
        public string equifaxFactorCode3 { get; set; }
        public string equifaxFactorCode4 { get; set; }
        public string equifaxFactorCode5 { get; set; }
        public decimal? personHoursPerWeek { get; set; }
        public decimal? personIncomeAmount { get; set; }
        public string personIncomeFrequencyType { get; set; }
        public decimal? personMonthlyIncome { get; set; }
        public bool? confirmedCRFCIncorrect { get; set; }
        public bool? confirmedCRFCEC { get; set; }
        public bool? confirmedCRDIL { get; set; }
        public bool? confirmedCRPFS { get; set; }
        public bool? confirmedOther { get; set; }
        public string confirmedOtherDescription { get; set; }
        public int? experian150Days { get; set; }
        public int? transUnion150Days { get; set; }
        public int? equifax150Days { get; set; }
        public int? pass30Days { get; set; }
        public int? pass60Days { get; set; }
        public int? pass90Days { get; set; }
        public int? pass120Days { get; set; }
        public int? pass150Days { get; set; }
        public bool? mortgageOnCredit { get; set; }
        public int? numberofTradelines { get; set; }
        public int? yearsofCreditOnFile { get; set; }
        public bool? creditCounseling { get; set; }
        public decimal? highestCreditLimit { get; set; }
        public string openBankruptcy2 { get; set; }
        public DateTime? priorBankruptcy2 { get; set; }
        public string bankruptcyStatus { get; set; }
        public DateTime? foreclosureSatisfied { get; set; }
        public string foreclosureStatus { get; set; }
        public string middleFicoScore { get; set; }
        public bool? no3rdPartyEmailIndicator { get; set; }
        public bool? authorizedToSignIndicator { get; set; }
        public bool? experianCreditScoreForDisclosure { get; set; }
        public bool? transUnionCreditScoreForDisclosure { get; set; }
        public bool? equifaxCreditScoreForDisclosure { get; set; }
        public int? experianCreditScoreRanksPercent { get; set; }
        public int? transUnionCreditScoreRanksPercent { get; set; }
        public int? equifaxCreditScoreRanksPercent { get; set; }
        public bool? experianMaterialTermsCreditByScore { get; set; }
        public bool? transUnionMaterialTermsCreditByScore { get; set; }
        public bool? equifaxMaterialTermsCreditByScore { get; set; }
        public bool? noCoApplicantIndicator { get; set; }
        public bool? veteranIndicator { get; set; }
        public bool? disabledIndicator { get; set; }
        public bool? firstTimeHomeBuyer { get; set; }
        public bool? relationshipWithRDEmployeeIndicator { get; set; }
        public string relationshipDescription { get; set; }
        public bool? creditScoreIndicator { get; set; }
        public bool? obtainLoanFromRHSIndicator { get; set; }
        public string nameToObtainLoanFromRHS { get; set; }
        public int? middleCreditScore { get; set; }
        public string tax4506LastStatus { get; set; }
        public string tax4506LastOrderNumber { get; set; }
        public string tax4506LastInvestor { get; set; }
        public int? tax4506LastOrderYear1 { get; set; }
        public int? tax4506LastOrderYear2 { get; set; }
        public int? tax4506LastOrderYear3 { get; set; }
        public int? tax4506LastOrderYear4 { get; set; }
        public string tax4506LastProductsOrdered { get; set; }
        public string tax4506LastTranscriptType { get; set; }
        public decimal? tax4506TotalYearlyIncome3 { get; set; }
        public decimal? tax4506TotalYearlyIncome4 { get; set; }
        public decimal? tax4506TotalYearlyJointIncome3 { get; set; }
        public decimal? tax4506TotalYearlyJointIncome4 { get; set; }
        public decimal? tax4506TotalYearlyVarianceIncome3 { get; set; }
        public decimal? tax4506TotalYearlyVarianceIncome4 { get; set; }
        public decimal? tax4506TotalYearlyVarianceJointIncome3 { get; set; }
        public decimal? tax4506TotalYearlyVarianceJointIncome4 { get; set; }
        public string tax4506LastUserIDWhoOrdered { get; set; }
        public string acountChekAssetId { get; set; }
        public string intuitReportId { get; set; }
        public string transactionPurposeDescription { get; set; }
        public int? validDaysForConsentCount { get; set; }
        public bool? authorizedCreditReportIndicator { get; set; }
        public DateTime? dateAuthorizedCreditReport { get; set; }
        public string creditReportAuthorizationMethod { get; set; }
        public string commentOfCreditReport { get; set; }
        public decimal? tax4506TotalYearlyIncome1 { get; set; }
        public decimal? tax4506TotalYearlyIncome2 { get; set; }
        public decimal? tax4506TotalYearlyVarianceIncome1 { get; set; }
        public decimal? tax4506TotalYearlyVarianceIncome2 { get; set; }
        public decimal? tax4506TotalYearlyJointIncome1 { get; set; }
        public decimal? tax4506TotalYearlyJointIncome2 { get; set; }
        public decimal? tax4506TotalYearlyVarianceJointIncome1 { get; set; }
        public decimal? tax4506TotalYearlyVarianceJointIncome2 { get; set; }
        public bool? hmdaNoCoApplicantIndicator { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffixToName { get; set; }
        public string borrowerTypeInSummary { get; set; }
        public bool? sSA89MortgageServiceIndicator { get; set; }
        public bool? sSA89BankingServiceIndicator { get; set; }
        public bool? sSA89BackgroundCheckIndicator { get; set; }
        public bool? sSA89LicenseRequirementIndicator { get; set; }
        public bool? sSA89CreditCheckIndicator { get; set; }
        public bool? sSA89OtherIndicator { get; set; }
        public string vestingTrusteeOfType { get; set; }
        public string poaSignatureText { get; set; }
        public string poaOccupancyIntent { get; set; }
        public DateTime? borrowerConsentRequestDate { get; set; }
        public string id { get; set; }
        public string altId { get; set; }
        public string applicantType { get; set; }
        public int? borrowerIndex { get; set; }
        public string fullName { get; set; }
        public bool? isBorrower { get; set; }

    }
}
