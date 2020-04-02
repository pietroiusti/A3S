/**
 * *************************************************
 * Copyright (c) 2020, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.6
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using za.co.grindrodbank.a3s.Converters;

namespace za.co.grindrodbank.a3s.A3SApiResources
{ 
    /// <summary>
    /// Models a sub-realm. 
    /// </summary>
    [DataContract]
    public partial class SubRealmSubmit : IEquatable<SubRealmSubmit>
    { 
        /// <summary>
        /// The name of the sub-realm.
        /// </summary>
        /// <value>The name of the sub-realm.</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the sub-realm.
        /// </summary>
        /// <value>A description of the sub-realm.</value>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of all the permission IDs for the permissions that are to be available within the sub-realm.
        /// </summary>
        /// <value>A list of all the permission IDs for the permissions that are to be available within the sub-realm.</value>
        [Required]
        [DataMember(Name="permissionIds", EmitDefaultValue=false)]
        public List<Guid> PermissionIds { get; set; }

        /// <summary>
        /// A list of all the application data policy IDs for the application data policies that are to be available within the sub-realm.
        /// </summary>
        /// <value>A list of all the application data policy IDs for the application data policies that are to be available within the sub-realm.</value>
        [Required]
        [DataMember(Name="applicationDataPolicyIds", EmitDefaultValue=false)]
        public List<Guid> ApplicationDataPolicyIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubRealmSubmit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PermissionIds: ").Append(PermissionIds).Append("\n");
            sb.Append("  ApplicationDataPolicyIds: ").Append(ApplicationDataPolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SubRealmSubmit)obj);
        }

        /// <summary>
        /// Returns true if SubRealmSubmit instances are equal
        /// </summary>
        /// <param name="other">Instance of SubRealmSubmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubRealmSubmit other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    PermissionIds == other.PermissionIds ||
                    PermissionIds != null &&
                    other.PermissionIds != null &&
                    PermissionIds.SequenceEqual(other.PermissionIds)
                ) && 
                (
                    ApplicationDataPolicyIds == other.ApplicationDataPolicyIds ||
                    ApplicationDataPolicyIds != null &&
                    other.ApplicationDataPolicyIds != null &&
                    ApplicationDataPolicyIds.SequenceEqual(other.ApplicationDataPolicyIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (PermissionIds != null)
                    hashCode = hashCode * 59 + PermissionIds.GetHashCode();
                    if (ApplicationDataPolicyIds != null)
                    hashCode = hashCode * 59 + ApplicationDataPolicyIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SubRealmSubmit left, SubRealmSubmit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubRealmSubmit left, SubRealmSubmit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
