using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDZondaTechTest.JsonObjects.Responses.Subdivisions
{
        public class SubdivisionResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("data")]
            public SubdivisionsObject[] Subdivisions { get; set; }

            public class SubdivisionsObject
            {
                [JsonProperty("id")]
                public long Id { get; set; }

                [JsonProperty("code")]
                public string Code { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("longitude")]
                public double Longitude { get; set; }

                [JsonProperty("latitude")]
                public double Latitude { get; set; }

                [JsonProperty("fieldSurveyTerritoryId")]
                public long FieldSurveyTerritoryId { get; set; }

                [JsonProperty("marketId")]
                public long MarketId { get; set; }

                [JsonProperty("subdivisionStatusId")]
                public long SubdivisionStatusId { get; set; }

                [JsonProperty("surveyMethodId")]
                public long SurveyMethodId { get; set; }

                [JsonProperty("activeSections")]
                public long ActiveSections { get; set; }

                [JsonProperty("futureSections")]
                public long FutureSections { get; set; }

                [JsonProperty("builtOutSections")]
                public long BuiltOutSections { get; set; }

                [JsonProperty("totalLots")]
                public long TotalLots { get; set; }

                [JsonProperty("fieldSurveyTerritoryName")]
                public string FieldSurveyTerritoryName { get; set; }

                [JsonProperty("marketName")]
                public string MarketName { get; set; }

                [JsonProperty("marketAbbreviation")]
                public string MarketAbbreviation { get; set; }

                [JsonProperty("subdivisionStatusCode")]
                public string SubdivisionStatusCode { get; set; }

                [JsonProperty("surveyMethodCode")]
                public string SurveyMethodCode { get; set; }

                [JsonProperty("county")]
                public string County { get; set; }

                [JsonProperty("community")]
                public object Community { get; set; }

                [JsonProperty("zoom17Date")]
                public string Zoom17Date { get; set; }

                [JsonProperty("zoom18Date")]
                public string Zoom18Date { get; set; }

                [JsonProperty("subdivisionGeometryId")]
                public object SubdivisionGeometryId { get; set; }

                [JsonProperty("subdivisionGeometryBoundingBoxId")]
                public object SubdivisionGeometryBoundingBoxId { get; set; }

                [JsonProperty("subdivisionGeometryBoundaryId")]
                public object SubdivisionGeometryBoundaryId { get; set; }

                [JsonProperty("subdivisionGeometryIntelligenceBoundaryId")]
                public long SubdivisionGeometryIntelligenceBoundaryId { get; set; }

                [JsonProperty("subdivisionGeometryIntelligenceBoundaryStatusId")]
                public long SubdivisionGeometryIntelligenceBoundaryStatusId { get; set; }

                [JsonProperty("subdivisionGeometryIntelligenceBoundaryStatusCode")]
                public string SubdivisionGeometryIntelligenceBoundaryStatusCode { get; set; }

                [JsonProperty("subdivisionGeometryIntelligenceBoundaryStatusChangeDate")]
                public string SubdivisionGeometryIntelligenceBoundaryStatusChangeDate { get; set; }

                [JsonProperty("nearMapImageDate")]
                public string NearMapImageDate { get; set; }

                [JsonProperty("imageBoxId")]
                public long ImageBoxId { get; set; }

                [JsonProperty("mostRecentIPointBatchDate")]
                public string? MostRecentIPointBatchDate { get; set; }

                [JsonProperty("iPoints")]
                public object IPoints { get; set; }

                [JsonProperty("validatediPoints")]
                public object ValidatediPoints { get; set; }

                [JsonProperty("subdivisionSpecificStatus")]
                public string SubdivisionSpecificStatus { get; set; }
            }
        }
}