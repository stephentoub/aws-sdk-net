/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Amazon.SecurityToken.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SecurityToken
{
    /// <summary>
    /// <para>Implementation for accessing SecurityTokenService</para>
    ///
    /// Security Token Service 
    /// <para>
    /// Security Token Service (STS) enables you to request temporary, limited-privilege credentials
    /// for users. This guide provides descriptions of the STS API. For more information about
    /// using this service, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityTokenServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecurityTokenServiceClient()
            : base(new AmazonSecurityTokenServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(RegionEndpoint region)
            : base(new AmazonSecurityTokenServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            if(this.Config.RetryMode == RequestRetryMode.Standard)
            {
                pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new SecurityTokenServiceStandardRetryPolicy(this.Config)));
            }
            if(this.Config.RetryMode == RequestRetryMode.Adaptive)
            {
                pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new SecurityTokenServiceAdaptiveRetryPolicy(this.Config)));
            }
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityTokenServiceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityTokenServiceAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssumeRole

        internal virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of temporary security credentials that you can use to access Amazon
        /// Web Services resources. These temporary credentials consist of an access key ID, a
        /// secret access key, and a security token. Typically, you use <c>AssumeRole</c> within
        /// your account or for cross-account access. For a comparison of <c>AssumeRole</c> with
        /// other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <c>AssumeRole</c> can be used to make
        /// API calls to any Amazon Web Services service with the following exception: You cannot
        /// call the Amazon Web Services STS <c>GetFederationToken</c> or <c>GetSessionToken</c>
        /// API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed session policies to this operation. You
        /// can pass a single JSON policy document to use as an inline session policy. You can
        /// also specify up to 10 managed policy Amazon Resource Names (ARNs) to use as managed
        /// session policies. The plaintext that you use for both inline and managed session policies
        /// can't exceed 2,048 characters. Passing policies to this operation returns new temporary
        /// credentials. The resulting session's permissions are the intersection of the role's
        /// identity-based policy and the session policies. You can use the role's temporary credentials
        /// in subsequent Amazon Web Services API calls to access resources in the account that
        /// owns the role. You cannot use session policies to grant more permissions than those
        /// allowed by the identity-based policy of the role that is being assumed. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a role, you create two policies: a role trust policy that specifies
        /// <i>who</i> can assume the role, and a permissions policy that specifies <i>what</i>
        /// can be done with the role. You specify the trusted principal that is allowed to assume
        /// the role in the role trust policy.
        /// </para>
        ///  
        /// <para>
        /// To assume a role from a different account, your Amazon Web Services account must be
        /// trusted by the role. The trust relationship is defined in the role's trust policy
        /// when the role is created. That trust policy states which accounts are allowed to delegate
        /// that access to users in the account. 
        /// </para>
        ///  
        /// <para>
        /// A user who wants to access a role in a different account must also have permissions
        /// that are delegated from the account administrator. The administrator must attach a
        /// policy that allows the user to call <c>AssumeRole</c> for the ARN of the role in the
        /// other account.
        /// </para>
        ///  
        /// <para>
        /// To allow a user to assume a role in the same account, you can do either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attach a policy to the user that allows the user to call <c>AssumeRole</c> (as long
        /// as the role's trust policy trusts the account).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add the user as a principal directly in the role's trust policy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can do either because the role’s trust policy acts as an IAM resource-based policy.
        /// When a resource-based policy grants access to a principal in the same account, no
        /// additional identity-based policy is required. For more information about trust policies
        /// and resource-based policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Tags</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass tag key-value pairs to your session. These tags are called
        /// session tags. For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// An administrator must grant you the permissions necessary to pass session tags. The
        /// administrator can also create granular permissions to allow you to pass only specific
        /// session tags. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_attribute-based-access-control.html">Tutorial:
        /// Using Tags for Attribute-Based Access Control</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can set the session tags as transitive. Transitive tags persist during role chaining.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining">Chaining
        /// Roles with Session Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Using MFA with AssumeRole</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can include multi-factor authentication (MFA) information when you
        /// call <c>AssumeRole</c>. This is useful for cross-account scenarios to ensure that
        /// the user that assumes the role has been authenticated with an Amazon Web Services
        /// MFA device. In that scenario, the trust policy of the role being assumed includes
        /// a condition that tests for MFA authentication. If the caller does not include valid
        /// MFA information, the request to assume the role is denied. The condition in a trust
        /// policy that tests for MFA authentication might look like the following example.
        /// </para>
        ///  
        /// <para>
        ///  <c>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
        /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
        /// </para>
        ///  
        /// <para>
        /// To use MFA with <c>AssumeRole</c>, you pass values for the <c>SerialNumber</c> and
        /// <c>TokenCode</c> parameters. The <c>SerialNumber</c> value identifies the user's hardware
        /// or virtual MFA device. The <c>TokenCode</c> is the time-based one-time password (TOTP)
        /// that the MFA device produces. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the total packed size of the session policies and
        /// session tags combined was too large. An Amazon Web Services conversion compresses
        /// the session policy document, session policy ARNs, and session tags into a packed binary
        /// format that has a separate limit. The error message indicates by percentage how close
        /// the policies and tags are to the upper size limit. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You could receive this error even though you meet other defined session policy and
        /// session tag limits. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-limits-entity-length">IAM
        /// and STS Entity Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        public virtual Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssumeRoleWithSAML

        internal virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithSAMLResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// via a SAML authentication response. This operation provides a mechanism for tying
        /// an enterprise identity store or directory to role-based Amazon Web Services access
        /// without user-specific credentials or configuration. For a comparison of <c>AssumeRoleWithSAML</c>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The temporary security credentials returned by this operation consist of an access
        /// key ID, a secret access key, and a security token. Applications can use these temporary
        /// security credentials to sign calls to Amazon Web Services services.
        /// </para>
        ///  
        /// <para>
        ///  <b>Session Duration</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <c>AssumeRoleWithSAML</c>
        /// last for one hour. However, you can use the optional <c>DurationSeconds</c> parameter
        /// to specify the duration of your session. Your role session lasts for the duration
        /// that you specify, or until the time specified in the SAML authentication response's
        /// <c>SessionNotOnOrAfter</c> value, whichever is shorter. You can provide a <c>DurationSeconds</c>
        /// value from 900 seconds (15 minutes) up to the maximum session duration setting for
        /// the role. This setting can have a value from 1 hour to 12 hours. To learn how to view
        /// the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <c>AssumeRole*</c> API
        /// operations or the <c>assume-role*</c> CLI commands. However the limit does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-role-chaining">Role
        /// chaining</a> limits your CLI or Amazon Web Services API role session to a maximum
        /// of one hour. When you use the <c>AssumeRole</c> API operation to assume a role, you
        /// can specify the duration of your role session with the <c>DurationSeconds</c> parameter.
        /// You can specify a parameter value of up to 43200 seconds (12 hours), depending on
        /// the maximum session duration setting for your role. However, if you assume a role
        /// using role chaining and provide a <c>DurationSeconds</c> parameter value greater than
        /// one hour, the operation fails.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <c>AssumeRoleWithSAML</c> can be used
        /// to make API calls to any Amazon Web Services service with the following exception:
        /// you cannot call the STS <c>GetFederationToken</c> or <c>GetSessionToken</c> API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policies</a> to this operation. You can pass a single JSON policy document to use
        /// as an inline session policy. You can also specify up to 10 managed policy Amazon Resource
        /// Names (ARNs) to use as managed session policies. The plaintext that you use for both
        /// inline and managed session policies can't exceed 2,048 characters. Passing policies
        /// to this operation returns new temporary credentials. The resulting session's permissions
        /// are the intersection of the role's identity-based policy and the session policies.
        /// You can use the role's temporary credentials in subsequent Amazon Web Services API
        /// calls to access resources in the account that owns the role. You cannot use session
        /// policies to grant more permissions than those allowed by the identity-based policy
        /// of the role that is being assumed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Calling <c>AssumeRoleWithSAML</c> does not require the use of Amazon Web Services
        /// security credentials. The identity of the caller is validated by using keys in the
        /// metadata document that is uploaded for the SAML provider entity for your identity
        /// provider. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <c>AssumeRoleWithSAML</c> can result in an entry in your CloudTrail logs.
        /// The entry includes the value in the <c>NameID</c> element of the SAML assertion. We
        /// recommend that you use a <c>NameIDType</c> that is not associated with any personally
        /// identifiable information (PII). For example, you could instead use the persistent
        /// identifier (<c>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</c>).
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Tags</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can configure your IdP to pass attributes into your SAML assertion
        /// as session tags. Each session tag consists of a key name and an associated value.
        /// For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can pass up to 50 session tags. The plaintext session tag keys can’t exceed 128
        /// characters and the values can’t exceed 256 characters. For these and additional limits,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html#reference_iam-limits-entity-length">IAM
        /// and STS Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// An Amazon Web Services conversion compresses the passed inline session policy, managed
        /// policy ARNs, and session tags into a packed binary format that has a separate limit.
        /// Your request can fail for this limit even if your plaintext meets the other requirements.
        /// The <c>PackedPolicySize</c> response element indicates by percentage how close the
        /// policies and tags for your request are to the upper size limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can pass a session tag with the same key as a tag that is attached to the role.
        /// When you do, session tags override the role's tags with the same key.
        /// </para>
        ///  
        /// <para>
        /// An administrator must grant you the permissions necessary to pass session tags. The
        /// administrator can also create granular permissions to allow you to pass only specific
        /// session tags. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_attribute-based-access-control.html">Tutorial:
        /// Using Tags for Attribute-Based Access Control</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can set the session tags as transitive. Transitive tags persist during role chaining.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining">Chaining
        /// Roles with Session Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>SAML Configuration</b> 
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <c>AssumeRoleWithSAML</c>, you must configure your
        /// SAML identity provider (IdP) to issue the claims required by Amazon Web Services.
        /// Additionally, you must use Identity and Access Management (IAM) to create a SAML provider
        /// entity in your Amazon Web Services account that represents your identity provider.
        /// You must also create an IAM role that specifies this SAML provider in its trust policy.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml.html">Creating
        /// SAML Identity Providers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml_relying-party.html">Configuring
        /// a Relying Party and Claims</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_saml.html">Creating
        /// a Role for SAML 2.0 Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRoleWithSAML service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <c>AssumeRoleWithWebIdentity</c> operation, it can
        /// also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by Amazon Web Services.
        /// Get a new identity token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the total packed size of the session policies and
        /// session tags combined was too large. An Amazon Web Services conversion compresses
        /// the session policy document, session policy ARNs, and session tags into a packed binary
        /// format that has a separate limit. The error message indicates by percentage how close
        /// the policies and tags are to the upper size limit. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You could receive this error even though you meet other defined session policy and
        /// session tag limits. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-limits-entity-length">IAM
        /// and STS Entity Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        public virtual Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleWithSAMLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssumeRoleWithWebIdentity

        internal virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithWebIdentityResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// in a mobile or web application with a web identity provider. Example providers include
        /// the OAuth 2.0 providers Login with Amazon and Facebook, or any OpenID Connect-compatible
        /// identity provider such as Google or <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-identity.html">Amazon
        /// Cognito federated identities</a>.
        /// 
        ///  <note> 
        /// <para>
        /// For mobile applications, we recommend that you use Amazon Cognito. You can use Amazon
        /// Cognito with the <a href="http://aws.amazon.com/sdkforios/">Amazon Web Services SDK
        /// for iOS Developer Guide</a> and the <a href="http://aws.amazon.com/sdkforandroid/">Amazon
        /// Web Services SDK for Android Developer Guide</a> to uniquely identify a user. You
        /// can also supply the user with a consistent identity throughout the lifetime of an
        /// application.
        /// </para>
        ///  
        /// <para>
        /// To learn more about Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-identity.html">Amazon
        /// Cognito identity pools</a> in <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling <c>AssumeRoleWithWebIdentity</c> does not require the use of Amazon Web Services
        /// security credentials. Therefore, you can distribute an application (for example, on
        /// mobile devices) that requests temporary security credentials without including long-term
        /// Amazon Web Services credentials in the application. You also don't need to deploy
        /// server-based proxy services that use long-term Amazon Web Services credentials. Instead,
        /// the identity of the caller is validated by using a token from the web identity provider.
        /// For a comparison of <c>AssumeRoleWithWebIdentity</c> with the other API operations
        /// that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials returned by this API consist of an access key ID,
        /// a secret access key, and a security token. Applications can use these temporary security
        /// credentials to sign calls to Amazon Web Services service API operations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Session Duration</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <c>AssumeRoleWithWebIdentity</c>
        /// last for one hour. However, you can use the optional <c>DurationSeconds</c> parameter
        /// to specify the duration of your session. You can provide a value from 900 seconds
        /// (15 minutes) up to the maximum session duration setting for the role. This setting
        /// can have a value from 1 hour to 12 hours. To learn how to view the maximum value for
        /// your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_update-role-settings.html#id_roles_update-session-duration">Update
        /// the maximum session duration for a role </a> in the <i>IAM User Guide</i>. The maximum
        /// session duration limit applies when you use the <c>AssumeRole*</c> API operations
        /// or the <c>assume-role*</c> CLI commands. However the limit does not apply when you
        /// use those operations to create a console URL. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <c>AssumeRoleWithWebIdentity</c> can
        /// be used to make API calls to any Amazon Web Services service with the following exception:
        /// you cannot call the STS <c>GetFederationToken</c> or <c>GetSessionToken</c> API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policies</a> to this operation. You can pass a single JSON policy document to use
        /// as an inline session policy. You can also specify up to 10 managed policy Amazon Resource
        /// Names (ARNs) to use as managed session policies. The plaintext that you use for both
        /// inline and managed session policies can't exceed 2,048 characters. Passing policies
        /// to this operation returns new temporary credentials. The resulting session's permissions
        /// are the intersection of the role's identity-based policy and the session policies.
        /// You can use the role's temporary credentials in subsequent Amazon Web Services API
        /// calls to access resources in the account that owns the role. You cannot use session
        /// policies to grant more permissions than those allowed by the identity-based policy
        /// of the role that is being assumed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Tags</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can configure your IdP to pass attributes into your web identity token
        /// as session tags. Each session tag consists of a key name and an associated value.
        /// For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can pass up to 50 session tags. The plaintext session tag keys can’t exceed 128
        /// characters and the values can’t exceed 256 characters. For these and additional limits,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html#reference_iam-limits-entity-length">IAM
        /// and STS Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// An Amazon Web Services conversion compresses the passed inline session policy, managed
        /// policy ARNs, and session tags into a packed binary format that has a separate limit.
        /// Your request can fail for this limit even if your plaintext meets the other requirements.
        /// The <c>PackedPolicySize</c> response element indicates by percentage how close the
        /// policies and tags for your request are to the upper size limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can pass a session tag with the same key as a tag that is attached to the role.
        /// When you do, the session tag overrides the role tag with the same key.
        /// </para>
        ///  
        /// <para>
        /// An administrator must grant you the permissions necessary to pass session tags. The
        /// administrator can also create granular permissions to allow you to pass only specific
        /// session tags. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_attribute-based-access-control.html">Tutorial:
        /// Using Tags for Attribute-Based Access Control</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can set the session tags as transitive. Transitive tags persist during role chaining.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html#id_session-tags_role-chaining">Chaining
        /// Roles with Session Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Identities</b> 
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <c>AssumeRoleWithWebIdentity</c>, you must have an
        /// identity token from a supported identity provider and create a role that the application
        /// can assume. The role that your application assumes must trust the identity provider
        /// that is associated with the identity token. In other words, the identity provider
        /// must be specified in the role's trust policy. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <c>AssumeRoleWithWebIdentity</c> can result in an entry in your CloudTrail
        /// logs. The entry includes the <a href="http://openid.net/specs/openid-connect-core-1_0.html#Claims">Subject</a>
        /// of the provided web identity token. We recommend that you avoid using any personally
        /// identifiable information (PII) in this field. For example, you could instead use a
        /// GUID or a pairwise identifier, as <a href="http://openid.net/specs/openid-connect-core-1_0.html#SubjectIDTypes">suggested
        /// in the OIDC specification</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about how to use OIDC federation and the <c>AssumeRoleWithWebIdentity</c>
        /// API, see the following resources: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc_manual.html">Using
        /// Web Identity Federation API Operations for Mobile Apps</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/sdkforios/">Amazon Web Services SDK for iOS Developer
        /// Guide</a> and <a href="http://aws.amazon.com/sdkforandroid/">Amazon Web Services SDK
        /// for Android Developer Guide</a>. These toolkits contain sample apps that show how
        /// to invoke the identity providers. The toolkits then show how to use the information
        /// from these providers to get and use temporary security credentials. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPCommunicationErrorException">
        /// The request could not be fulfilled because the identity provider (IDP) that was asked
        /// to verify the incoming identity token could not be reached. This is often a transient
        /// error caused by network conditions. Retry the request a limited number of times so
        /// that you don't exceed the request rate. If the error persists, the identity provider
        /// might be down or not responding.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <c>AssumeRoleWithWebIdentity</c> operation, it can
        /// also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by Amazon Web Services.
        /// Get a new identity token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the total packed size of the session policies and
        /// session tags combined was too large. An Amazon Web Services conversion compresses
        /// the session policy document, session policy ARNs, and session tags into a packed binary
        /// format that has a separate limit. The error message indicates by percentage how close
        /// the policies and tags are to the upper size limit. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You could receive this error even though you meet other defined session policy and
        /// session tag limits. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-limits-entity-length">IAM
        /// and STS Entity Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        public virtual Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleWithWebIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssumeRoot

        internal virtual AssumeRootResponse AssumeRoot(AssumeRootRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRootRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRootResponseUnmarshaller.Instance;

            return Invoke<AssumeRootResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of short term credentials you can use to perform privileged tasks on
        /// a member account in your organization.
        /// 
        ///  
        /// <para>
        /// Before you can launch a privileged session, you must have centralized root access
        /// in your organization. For steps to enable this feature, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-enable-root-access.html">Centralize
        /// root access for member accounts</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The STS global endpoint is not supported for AssumeRoot. You must send this request
        /// to a Regional STS endpoint. For more information, see <a href="https://docs.aws.amazon.com/STS/latest/APIReference/welcome.html#sts-endpoints">Endpoints</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can track AssumeRoot in CloudTrail logs to determine what actions were performed
        /// in a session. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-track-privileged-tasks.html">Track
        /// privileged tasks in CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeRoot service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoot">REST API Reference for AssumeRoot Operation</seealso>
        public virtual Task<AssumeRootResponse> AssumeRootAsync(AssumeRootRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRootRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRootResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRootResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DecodeAuthorizationMessage

        internal virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return Invoke<DecodeAuthorizationMessageResponse>(request, options);
        }



        /// <summary>
        /// Decodes additional information about the authorization status of a request from an
        /// encoded message returned in response to an Amazon Web Services request.
        /// 
        ///  
        /// <para>
        /// For example, if a user is not authorized to perform an operation that he or she has
        /// requested, the request returns a <c>Client.UnauthorizedOperation</c> response (an
        /// HTTP 403 response). Some Amazon Web Services operations additionally return an encoded
        /// message that can provide details about this authorization failure. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only certain Amazon Web Services operations return an encoded authorization message.
        /// The documentation for an individual operation indicates whether that operation returns
        /// an encoded message in addition to returning an HTTP code.
        /// </para>
        ///  </note> 
        /// <para>
        /// The message is encoded because the details of the authorization status can contain
        /// privileged information that the user who requested the operation should not see. To
        /// decode an authorization status message, a user must be granted permissions through
        /// an IAM <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">policy</a>
        /// to request the <c>DecodeAuthorizationMessage</c> (<c>sts:DecodeAuthorizationMessage</c>)
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// The decoded message includes the following type of information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether the request was denied due to an explicit deny or due to the absence of an
        /// explicit allow. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-denyallow">Determining
        /// Whether a Request is Allowed or Denied</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principal who made the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The values of condition keys in the context of the user's request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecodeAuthorizationMessage service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidAuthorizationMessageException">
        /// The error returned if the message passed to <c>DecodeAuthorizationMessage</c> was
        /// invalid. This can happen if the token contains invalid characters, such as line breaks,
        /// or if the message has expired.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        public virtual Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DecodeAuthorizationMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccessKeyInfo

        internal virtual GetAccessKeyInfoResponse GetAccessKeyInfo(GetAccessKeyInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyInfoResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyInfoResponse>(request, options);
        }



        /// <summary>
        /// Returns the account identifier for the specified access key ID.
        /// 
        ///  
        /// <para>
        /// Access keys consist of two parts: an access key ID (for example, <c>AKIAIOSFODNN7EXAMPLE</c>)
        /// and a secret access key (for example, <c>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</c>).
        /// For more information about access keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html">Managing
        /// Access Keys for IAM Users</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you pass an access key ID to this operation, it returns the ID of the Amazon
        /// Web Services account to which the keys belong. Access key IDs beginning with <c>AKIA</c>
        /// are long-term credentials for an IAM user or the Amazon Web Services account root
        /// user. Access key IDs beginning with <c>ASIA</c> are temporary credentials that are
        /// created using STS operations. If the account in the response belongs to you, you can
        /// sign in as the root user and review your root user access keys. Then, you can pull
        /// a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_getting-report.html">credentials
        /// report</a> to learn which IAM user owns the keys. To learn who requested the temporary
        /// credentials for an <c>ASIA</c> access key, view the STS events in your <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">CloudTrail
        /// logs</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not indicate the state of the access key. The key might be active,
        /// inactive, or deleted. Active keys might not have permissions to perform an operation.
        /// Providing a deleted access key might return an error that the key doesn't exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessKeyInfo service method, as returned by SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetAccessKeyInfo">REST API Reference for GetAccessKeyInfo Operation</seealso>
        public virtual Task<GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessKeyInfoResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCallerIdentity

        internal virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCallerIdentityResponse>(request, options);
        }



        /// <summary>
        /// Returns details about the IAM user or role whose credentials are used to call the
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// No permissions are required to perform this operation. If an administrator attaches
        /// a policy to your identity that explicitly denies access to the <c>sts:GetCallerIdentity</c>
        /// action, you can still perform this operation. Permissions are not required because
        /// the same information is returned when access is denied. To view an example response,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_access-denied-delete-mfa">I
        /// Am Not Authorized to Perform: iam:DeleteVirtualMFADevice</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallerIdentity service method, as returned by SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        public virtual Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCallerIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFederationToken

        internal virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return Invoke<GetFederationTokenResponse>(request, options);
        }



        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret access key, and a security token) for a user. A typical use is in a proxy application
        /// that gets temporary security credentials on behalf of distributed applications inside
        /// a corporate network.
        /// 
        ///  
        /// <para>
        /// You must call the <c>GetFederationToken</c> operation using the long-term security
        /// credentials of an IAM user. As a result, this call is appropriate in contexts where
        /// those credentials can be safeguarded, usually in a server-based application. For a
        /// comparison of <c>GetFederationToken</c> with the other API operations that produce
        /// temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although it is possible to call <c>GetFederationToken</c> using the security credentials
        /// of an Amazon Web Services account root user rather than an IAM user that you create
        /// for the purpose of a proxy application, we do not recommend it. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#lock-away-credentials">Safeguard
        /// your root user credentials and don't use them for everyday tasks</a> in the <i>IAM
        /// User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can create a mobile-based or browser-based app that can authenticate users using
        /// a web identity provider like Login with Amazon, Facebook, Google, or an OpenID Connect-compatible
        /// identity provider. In this case, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
        /// Cognito</a> or <c>AssumeRoleWithWebIdentity</c>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Session duration</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary credentials are valid for the specified duration, from 900 seconds (15
        /// minutes) up to a maximum of 129,600 seconds (36 hours). The default session duration
        /// is 43,200 seconds (12 hours). Temporary credentials obtained by using the root user
        /// credentials have a maximum duration of 3,600 seconds (1 hour).
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the temporary credentials created by <c>GetFederationToken</c> in any
        /// Amazon Web Services service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM operations using the CLI or the Amazon Web Services API. This
        /// limitation does not apply to console sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS operations except <c>GetCallerIdentity</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use temporary credentials for single sign-on (SSO) to the console.
        /// </para>
        ///  
        /// <para>
        /// You must pass an inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policy</a> to this operation. You can pass a single JSON policy document to use as
        /// an inline session policy. You can also specify up to 10 managed policy Amazon Resource
        /// Names (ARNs) to use as managed session policies. The plaintext that you use for both
        /// inline and managed session policies can't exceed 2,048 characters.
        /// </para>
        ///  
        /// <para>
        /// Though the session policy parameters are optional, if you do not pass a policy, then
        /// the resulting federated user session has no permissions. When you pass session policies,
        /// the session permissions are the intersection of the IAM user policies and the session
        /// policies that you pass. This gives you a way to further restrict the permissions for
        /// a federated user. You cannot use session policies to grant more permissions than those
        /// that are defined in the permissions policy of the IAM user. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>. For information about using <c>GetFederationToken</c>
        /// to create temporary security credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getfederationtoken">GetFederationToken—Federation
        /// Through a Custom Identity Broker</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the credentials to access a resource that has a resource-based policy.
        /// If that policy specifically references the federated user session in the <c>Principal</c>
        /// element of the policy, the session has the permissions allowed by the policy. These
        /// permissions are granted in addition to the permissions granted by the session policies.
        /// </para>
        ///  
        /// <para>
        ///  <b>Tags</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass tag key-value pairs to your session. These are called session
        /// tags. For more information about session tags, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can create a mobile-based or browser-based app that can authenticate users using
        /// a web identity provider like Login with Amazon, Facebook, Google, or an OpenID Connect-compatible
        /// identity provider. In this case, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
        /// Cognito</a> or <c>AssumeRoleWithWebIdentity</c>. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// An administrator must grant you the permissions necessary to pass session tags. The
        /// administrator can also create granular permissions to allow you to pass only specific
        /// session tags. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_attribute-based-access-control.html">Tutorial:
        /// Using Tags for Attribute-Based Access Control</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Tag key–value pairs are not case sensitive, but case is preserved. This means that
        /// you cannot have separate <c>Department</c> and <c>department</c> tag keys. Assume
        /// that the user that you are federating has the <c>Department</c>=<c>Marketing</c> tag
        /// and you pass the <c>department</c>=<c>engineering</c> session tag. <c>Department</c>
        /// and <c>department</c> are not saved as separate tags, and the session tag passed in
        /// the request takes precedence over the user tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the total packed size of the session policies and
        /// session tags combined was too large. An Amazon Web Services conversion compresses
        /// the session policy document, session policy ARNs, and session tags into a packed binary
        /// format that has a separate limit. The error message indicates by percentage how close
        /// the policies and tags are to the upper size limit. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_session-tags.html">Passing
        /// Session Tags in STS</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You could receive this error even though you meet other defined session policy and
        /// session tag limits. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-limits-entity-length">IAM
        /// and STS Entity Character Limits</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetFederationTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSessionToken

        internal virtual GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }
        internal virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return Invoke<GetSessionTokenResponse>(request, options);
        }


        /// <summary>
        /// Returns a set of temporary credentials for an Amazon Web Services account or IAM user.
        /// The credentials consist of an access key ID, a secret access key, and a security token.
        /// Typically, you use <c>GetSessionToken</c> if you want to use MFA to protect programmatic
        /// calls to specific Amazon Web Services API operations like Amazon EC2 <c>StopInstances</c>.
        /// 
        ///  
        /// <para>
        /// MFA-enabled IAM users must call <c>GetSessionToken</c> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// the call returns, IAM users can then make programmatic calls to API operations that
        /// require MFA authentication. An incorrect MFA code causes the API to return an access
        /// denied error. For a comparison of <c>GetSessionToken</c> with the other API operations
        /// that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// No permissions are required for users to perform this operation. The purpose of the
        /// <c>sts:GetSessionToken</c> operation is to authenticate the user using MFA. You cannot
        /// use policies to control authentication operations. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getsessiontoken.html">Permissions
        /// for GetSessionToken</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Session Duration</b> 
        /// </para>
        ///  
        /// <para>
        /// The <c>GetSessionToken</c> operation must be called by using the long-term Amazon
        /// Web Services security credentials of an IAM user. Credentials that are created by
        /// IAM users are valid for the duration that you specify. This duration can range from
        /// 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours), with a default
        /// of 43,200 seconds (12 hours). Credentials based on account credentials can range from
        /// 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default of 1 hour. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <c>GetSessionToken</c> can be used to
        /// make API calls to any Amazon Web Services service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM API operations unless MFA authentication information is included
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <c>AssumeRole</c> or <c>GetCallerIdentity</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The credentials that <c>GetSessionToken</c> returns are based on permissions associated
        /// with the IAM user whose credentials were used to call the operation. The temporary
        /// credentials have the same permissions as the IAM user.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although it is possible to call <c>GetSessionToken</c> using the security credentials
        /// of an Amazon Web Services account root user rather than an IAM user, we do not recommend
        /// it. If <c>GetSessionToken</c> is called using root user credentials, the temporary
        /// credentials have root user permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#lock-away-credentials">Safeguard
        /// your root user credentials and don't use them for everyday tasks</a> in the <i>IAM
        /// User Guide</i> 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about using <c>GetSessionToken</c> to create temporary credentials,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetSessionTokenAsync(new GetSessionTokenRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a set of temporary credentials for an Amazon Web Services account or IAM user.
        /// The credentials consist of an access key ID, a secret access key, and a security token.
        /// Typically, you use <c>GetSessionToken</c> if you want to use MFA to protect programmatic
        /// calls to specific Amazon Web Services API operations like Amazon EC2 <c>StopInstances</c>.
        /// 
        ///  
        /// <para>
        /// MFA-enabled IAM users must call <c>GetSessionToken</c> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// the call returns, IAM users can then make programmatic calls to API operations that
        /// require MFA authentication. An incorrect MFA code causes the API to return an access
        /// denied error. For a comparison of <c>GetSessionToken</c> with the other API operations
        /// that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_sts-comparison.html">Compare
        /// STS credentials</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// No permissions are required for users to perform this operation. The purpose of the
        /// <c>sts:GetSessionToken</c> operation is to authenticate the user using MFA. You cannot
        /// use policies to control authentication operations. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_getsessiontoken.html">Permissions
        /// for GetSessionToken</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Session Duration</b> 
        /// </para>
        ///  
        /// <para>
        /// The <c>GetSessionToken</c> operation must be called by using the long-term Amazon
        /// Web Services security credentials of an IAM user. Credentials that are created by
        /// IAM users are valid for the duration that you specify. This duration can range from
        /// 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours), with a default
        /// of 43,200 seconds (12 hours). Credentials based on account credentials can range from
        /// 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default of 1 hour. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <c>GetSessionToken</c> can be used to
        /// make API calls to any Amazon Web Services service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM API operations unless MFA authentication information is included
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <c>AssumeRole</c> or <c>GetCallerIdentity</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The credentials that <c>GetSessionToken</c> returns are based on permissions associated
        /// with the IAM user whose credentials were used to call the operation. The temporary
        /// credentials have the same permissions as the IAM user.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although it is possible to call <c>GetSessionToken</c> using the security credentials
        /// of an Amazon Web Services account root user rather than an IAM user, we do not recommend
        /// it. If <c>GetSessionToken</c> is called using root user credentials, the temporary
        /// credentials have root user permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#lock-away-credentials">Safeguard
        /// your root user credentials and don't use them for everyday tasks</a> in the <i>IAM
        /// User Guide</i> 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about using <c>GetSessionToken</c> to create temporary credentials,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}