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
 * The version of the OpenAPI document: 1.1.4
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
    /// Models a user profile, which enables context based access for the same user identity, when creating or updating a user profile. 
    /// </summary>
    [DataContract]
    public partial class UserProfileSubmit : IEquatable<UserProfileSubmit>
    { 
        /// <summary>
        /// The name of the user profile. This must be unique per user.
        /// </summary>
        /// <value>The name of the user profile. This must be unique per user.</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A brief description of a user profile and it&#39;s intent.
        /// </summary>
        /// <value>A brief description of a user profile and it&#39;s intent.</value>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The UUID identifier for a sub-realm.
        /// </summary>
        /// <value>The UUID identifier for a sub-realm.</value>
        [Required]
        [DataMember(Name="subRealmId", EmitDefaultValue=false)]
        public Guid SubRealmId { get; set; }

        /// <summary>
        /// Gets or Sets RoleIds
        /// </summary>
        [Required]
        [DataMember(Name="roleIds", EmitDefaultValue=false)]
        public List<Guid> RoleIds { get; set; }

        /// <summary>
        /// Gets or Sets TeamIds
        /// </summary>
        [Required]
        [DataMember(Name="teamIds", EmitDefaultValue=false)]
        public List<Guid> TeamIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileSubmit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubRealmId: ").Append(SubRealmId).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserProfileSubmit)obj);
        }

        /// <summary>
        /// Returns true if UserProfileSubmit instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProfileSubmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileSubmit other)
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
                    SubRealmId == other.SubRealmId ||
                    SubRealmId != null &&
                    SubRealmId.Equals(other.SubRealmId)
                ) && 
                (
                    RoleIds == other.RoleIds ||
                    RoleIds != null &&
                    other.RoleIds != null &&
                    RoleIds.SequenceEqual(other.RoleIds)
                ) && 
                (
                    TeamIds == other.TeamIds ||
                    TeamIds != null &&
                    other.TeamIds != null &&
                    TeamIds.SequenceEqual(other.TeamIds)
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
                    if (SubRealmId != null)
                    hashCode = hashCode * 59 + SubRealmId.GetHashCode();
                    if (RoleIds != null)
                    hashCode = hashCode * 59 + RoleIds.GetHashCode();
                    if (TeamIds != null)
                    hashCode = hashCode * 59 + TeamIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserProfileSubmit left, UserProfileSubmit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserProfileSubmit left, UserProfileSubmit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
