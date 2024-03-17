namespace ArtShop.Data.Models.Constants
{
    public static class ValidationConstants
    {
        public static class ArtworkValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;

            public const int SummaryMinLength = 20;
            public const int SummaryMaxLength = 250;

            public const int DescriptionMinLength = 40;
            public const int DescriptionMaxLength = 500;

            public const int PriceMinValue = 1;
            public const int PriceMaxValue = 1000000;

            public const int YearMadeMinValue = 1;
            public const int YearMadeMaxValue = 5000;

            public const double DimensionMinValue = 0.1;
            public const double DimensionMaxValue = 500;
        }

        public static class AddressValidationConstants
        {
            public const int StreetNameMinLength = 3;
            public const int StreetNameMaxLength = 100;

            public const int ZipCodeMinLength = 3;
            public const int ZipCodeMaxLength = 10;
        }

        public static class CategoryValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
        }

        public static class CityValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class CountryValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class ReviewValidationConstants
        {
            public const int CommentMaxLength = 500;

            public const int RatingMinValue = 0;
            public const int RatingMaxValue = 5;
        }

        public static class StyleValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
        }

        public static class SubjectValidationConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
        }

        public static class ErrorMessages
        {
            public const string RequiredErrorMessage = "The field {0} is required.";
            public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters.";
            public const string NumberValueErrorMessage = "The {0} must be between {1} and {2}.";
        }
    }
}
