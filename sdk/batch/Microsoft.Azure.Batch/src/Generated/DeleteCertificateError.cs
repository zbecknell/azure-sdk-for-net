// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error encountered by the Batch service when deleting a certificate.
    /// </summary>
    public partial class DeleteCertificateError : IPropertyMetadata
    {
        #region Constructors

        internal DeleteCertificateError(Models.DeleteCertificateError protocolObject)
        {
            this.Code = protocolObject.Code;
            this.Message = protocolObject.Message;
            this.Values = NameValuePair.ConvertFromProtocolCollectionReadOnly(protocolObject.Values);
        }

        #endregion Constructors

        #region DeleteCertificateError

        /// <summary>
        /// Gets a code for the certificate deletion error. See <see cref="Common.BatchErrorCodeStrings"/> for possible values.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets a message describing the certificagte deletion error, intended to be suitable for display in a user interface.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets a list of additional error details related to the certificate deletion error.
        /// </summary>
        public IReadOnlyList<NameValuePair> Values { get; }

        #endregion // DeleteCertificateError

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}