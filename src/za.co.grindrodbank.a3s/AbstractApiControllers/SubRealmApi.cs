/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.3
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using za.co.grindrodbank.a3s.Attributes;
using Microsoft.AspNetCore.Authorization;
using za.co.grindrodbank.a3s.A3SApiResources;

namespace za.co.grindrodbank.a3s.AbstractApiControllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class SubRealmApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new Sub-Realm.
        /// </summary>
        /// <remarks>Create a new Sub-Realm.</remarks>
        /// <param name="subRealmSubmit"></param>
        /// <response code="200">Successful. Sub-Realm created.</response>
        /// <response code="400">Invalid parameters.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - Not authorized to create a Sub-Realm.</response>
        /// <response code="422">Non-Processible request. The request was correctly structured but some business rules were violated, preventing the creation of the Sub-Realm.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/subrealms", Name = "CreateSubRealm")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SubRealm))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> CreateSubRealmAsync([FromBody]SubRealmSubmit subRealmSubmit);

        /// <summary>
        /// Deletes a sub-realm.
        /// </summary>
        /// <remarks>Deletes a sub-realm.</remarks>
        /// <param name="subRealmId">The UUID of the Sub-Realm.</param>
        /// <response code="204">No Content.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to delete Sub-Realms.</response>
        /// <response code="404">Sub-Realm not found.</response>
        /// <response code="422">Non-Processible request. Usually returned when the request is correctly structured but some business rules have been violated.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpDelete]
        [Route("/subrealms/{subRealmId}", Name = "DeleteSubRealm")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> DeleteSubRealmAsync([FromRoute][Required]Guid subRealmId);

        /// <summary>
        /// Get a Sub-Realm.
        /// </summary>
        /// <remarks>Get a Sub-Realm by its UUID.</remarks>
        /// <param name="subRealmId">The UUID of the Sub-Realm.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to read Sub-Realms.</response>
        /// <response code="404">Sub-Realm not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/subrealms/{subRealmId}", Name = "GetSubRealm")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SubRealm))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> GetSubRealmAsync([FromRoute][Required]Guid subRealmId);

        /// <summary>
        /// Search for Sub-Realms.
        /// </summary>
        /// <remarks>Search for Sub-Realms.</remarks>
        /// <param name="page">The page to view.</param>
        /// <param name="size">The size of a page.</param>
        /// <param name="includeRelations">Determines whether related entities, such as any associated permissions, are returned. </param>
        /// <param name="filterName">A search query filter on the name of the sub-realm.</param>
        /// <param name="orderBy">a comma separated list of fields in their sort order. Ascending order is assumed. Append &#39;_desc&#39; after a field to indicate descending order.  Supported fields. &#39;name&#39;.</param>
        /// <response code="200">OK</response>
        /// <response code="204">No Content.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to access the list of Sub Realms.</response>
        /// <response code="404">Sub-Realm list not found.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/subrealms", Name = "ListSubRealms")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SubRealm>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> ListSubRealmsAsync([FromQuery]int page, [FromQuery][Range(1, 20)]int size, [FromQuery]bool includeRelations, [FromQuery][StringLength(255, MinimumLength=0)]string filterName, [FromQuery]string orderBy);

        /// <summary>
        /// Update a Sub-Realm.
        /// </summary>
        /// <remarks>Update a Sub-Realm by its UUID.</remarks>
        /// <param name="subRealmId">The UUID of the Sub-Realm.</param>
        /// <param name="subRealmSubmit"></param>
        /// <response code="200">OK.</response>
        /// <response code="400">Bad Request.</response>
        /// <response code="401">Not authenticated.</response>
        /// <response code="403">Forbidden - You are not authorized to update Sub-Realms.</response>
        /// <response code="404">Sub-Realm not found.</response>
        /// <response code="422">Non-Processible request. The request was correctly structured but some business rules were violated, preventing the update of the Sub-Realm.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPut]
        [Route("/subrealms/{subRealmId}", Name = "UpdateSubRealm")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SubRealm))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 422, type: typeof(ErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(ErrorResponse))]
        public abstract Task<IActionResult> UpdateSubRealmAsync([FromRoute][Required]Guid subRealmId, [FromBody]SubRealmSubmit subRealmSubmit);
    }
}
