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
    /// Models a user profile, which enables context based access for the same user identity. 
    /// </summary>
    [DataContract]
    public partial class UserProfile : IEquatable<UserProfile>
    { 
        /// <summary>
        /// The unique UUID for a user profile. 
        /// </summary>
        /// <value>The unique UUID for a user profile. </value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// The name of the user profile. This must be unique per user.
        /// </summary>
        /// <value>The name of the user profile. This must be unique per user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A brief description of a user profile and it&#39;s intent.
        /// </summary>
        /// <value>A brief description of a user profile and it&#39;s intent.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The UUID identifier for a sub-realm.
        /// </summary>
        /// <value>The UUID identifier for a sub-realm.</value>
        [DataMember(Name="subRealmId", EmitDefaultValue=false)]
        public Guid SubRealmId { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<Team> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfile {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubRealmId: ").Append(SubRealmId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserProfile)obj);
        }

        /// <summary>
        /// Returns true if UserProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfile other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
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
                    Roles == other.Roles ||
                    Roles != null &&
                    other.Roles != null &&
                    Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    Teams == other.Teams ||
                    Teams != null &&
                    other.Teams != null &&
                    Teams.SequenceEqual(other.Teams)
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
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (SubRealmId != null)
                    hashCode = hashCode * 59 + SubRealmId.GetHashCode();
                    if (Roles != null)
                    hashCode = hashCode * 59 + Roles.GetHashCode();
                    if (Teams != null)
                    hashCode = hashCode * 59 + Teams.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserProfile left, UserProfile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserProfile left, UserProfile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
