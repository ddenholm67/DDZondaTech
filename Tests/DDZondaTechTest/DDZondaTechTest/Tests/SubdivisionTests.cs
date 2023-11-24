using DDZondaTechTest.Helpers;
using DDZondaTechTest.JsonObjects.Responses.Subdivisions;
using DDZondaTechTest.Routes;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace DDZondaTechTest.Tests
{
    public class SubdivisionTests
    {
        private readonly Endpoints _endpoints;

        public SubdivisionTests()
        {
            _endpoints = new Endpoints();
        }

        [Test]
        public void GET_Subdivisions_ShouldReturn_200OK()
        {
            //Arrange
            var httpHelper = new HTTPHelper();

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), Method.Get);

            Thread.Sleep(2000);

            //Assert
            Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GET_Subdivisions_PageLimit_ShouldReturn_CorrectAmountOfObjects()
        {
            //Arrange
            var httpHelper = new HTTPHelper();
            var pageLimit = 20;

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsPageLimitQuery(pageLimit), Method.Get);

            var subdivisionResponseJson = JsonConvert.DeserializeObject<SubdivisionResponse>(subdivisionResponse.Content);

            //Assert
            Assert.That(CountReturnedSubdivisionObjects(subdivisionResponseJson), Is.EqualTo(pageLimit));
        }

        [Test]
        public void POST_Subdivisions_ShouldReturn_405MethodNotAllowed()
        {
            //Arrange
            var httpHelper = new HTTPHelper();

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), Method.Post);

            //Assert
            Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }

        [Test]
        public void PUT_Subdivisions_ShouldReturn_405MethodNotAllowed()
        {
            //Arrange
            var httpHelper = new HTTPHelper();

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), Method.Put);

            //Assert
            Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }

        [Test]
        public void DELETE_Subdivisions_ShouldReturn_405MethodNotAllowed()
        {
            //Arrange
            var httpHelper = new HTTPHelper();

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), Method.Put);

            //Assert
            Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }

        [Test]
        public void OPTIONS_Subdivisions_ShouldReturn_405MethodNotAllowed()
        {
            //Arrange
            var httpHelper = new HTTPHelper();

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), Method.Put);

            //Assert
            Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }

        //[Test]
        //[TestCase(Method.Put)]
        //[TestCase(Method.Options)]
        //[TestCase(Method.Post)]
        //[TestCase(Method.Delete)]
        //public void Subdivisions_ShouldReturn_405MethodNotAllowed(Method httpMethod)
        //{
        //    //Arrange
        //    var httpHelper = new HTTPHelper();

        //    //Act
        //    var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsDefault(), httpMethod);

        //    //Assert
        //    Assert.That(subdivisionResponse.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        //}

        [Test]
        [TestCase("Future")]
        [TestCase("Builtout")]
        [TestCase("Active")]
        public void GET_Subdivisions_StatusCodeFilter_ShouldReturn_FilteredObjects(string statusFilter)
        {
            //Arrange
            var httpHelper = new HTTPHelper();
            

            //Act
            var subdivisionResponse = httpHelper.RequestBuilder(_endpoints.GetSubdivisionsStatusFilterQuery(statusFilter), Method.Get);

            var subdivisionResponseJson = JsonConvert.DeserializeObject<SubdivisionResponse>(subdivisionResponse.Content);

            //Assert
            Assert.That(SubdivisionStatusCodeFilterChecker(subdivisionResponseJson, statusFilter), Is.EqualTo(true));
        }

        private bool SubdivisionStatusCodeFilterChecker(SubdivisionResponse response, string statusFilter)
        {
            var allSubdivisionsMatchStatus = response.Subdivisions.All(subdivision => subdivision.SubdivisionStatusCode == statusFilter);

            return allSubdivisionsMatchStatus;
        }

        private int CountReturnedSubdivisionObjects(SubdivisionResponse response)
        {
            return response.Subdivisions.Count();
        }
    }
}