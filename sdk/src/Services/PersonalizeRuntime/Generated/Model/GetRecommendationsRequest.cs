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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecommendations operation.
    /// Returns a list of recommended items. For campaigns, the campaign's Amazon Resource
    /// Name (ARN) is required and the required user and item input depends on the recipe
    /// type used to create the solution backing the campaign as follows:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// USER_PERSONALIZATION - <c>userId</c> required, <c>itemId</c> not used
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// RELATED_ITEMS - <c>itemId</c> required, <c>userId</c> not used
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Campaigns that are backed by a solution created using a recipe of type PERSONALIZED_RANKING
    /// use the API.
    /// </para>
    ///  </note> 
    /// <para>
    ///  For recommenders, the recommender's ARN is required and the required item and user
    /// input depends on the use case (domain-based recipe) backing the recommender. For information
    /// on use case requirements see <a href="https://docs.aws.amazon.com/personalize/latest/dg/domain-use-cases.html">Choosing
    /// recommender use cases</a>. 
    /// </para>
    /// </summary>
    public partial class GetRecommendationsRequest : AmazonPersonalizeRuntimeRequest
    {
        private string _campaignArn;
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _filterArn;
        private Dictionary<string, string> _filterValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _itemId;
        private Dictionary<string, List<string>> _metadataColumns = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _numResults;
        private List<Promotion> _promotions = AWSConfigs.InitializeCollections ? new List<Promotion>() : null;
        private string _recommenderArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign to use for getting recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CampaignArn
        {
            get { return this._campaignArn; }
            set { this._campaignArn = value; }
        }

        // Check to see if CampaignArn property is set
        internal bool IsSetCampaignArn()
        {
            return this._campaignArn != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The contextual metadata to use when getting recommendations. Contextual metadata includes
        /// any interaction information that might be relevant when getting a user's recommendations,
        /// such as the user's current location or device type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=150)]
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && (this._context.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter to apply to the returned recommendations. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// Recommendations</a>.
        /// </para>
        ///  
        /// <para>
        /// When using this parameter, be sure the filter resource is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The values to use when filtering recommendations. For each placeholder parameter in
        /// your filter expression, provide the parameter name (in matching case) as a key and
        /// the filter value(s) as the corresponding value. Separate multiple values for one parameter
        /// with a comma. 
        /// </para>
        ///  
        /// <para>
        /// For filter expressions that use an <c>INCLUDE</c> element to include items, you must
        /// provide values for all parameters that are defined in the expression. For filters
        /// with expressions that use an <c>EXCLUDE</c> element to exclude items, you can omit
        /// the <c>filter-values</c>.In this case, Amazon Personalize doesn't use that portion
        /// of the expression to filter recommendations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// recommendations and user segments</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25)]
        public Dictionary<string, string> FilterValues
        {
            get { return this._filterValues; }
            set { this._filterValues = value; }
        }

        // Check to see if FilterValues property is set
        internal bool IsSetFilterValues()
        {
            return this._filterValues != null && (this._filterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The item ID to provide recommendations for.
        /// </para>
        ///  
        /// <para>
        /// Required for <c>RELATED_ITEMS</c> recipe type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataColumns. 
        /// <para>
        /// If you enabled metadata in recommendations when you created or updated the campaign
        /// or recommender, specify the metadata columns from your Items dataset to include in
        /// item recommendations. The map key is <c>ITEMS</c> and the value is a list of column
        /// names from your Items dataset. The maximum number of columns you can provide is 10.
        /// </para>
        ///  
        /// <para>
        ///  For information about enabling metadata for a campaign, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/campaigns.html#create-campaign-return-metadata">Enabling
        /// metadata in recommendations for a campaign</a>. For information about enabling metadata
        /// for a recommender, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/creating-recommenders.html#create-recommender-return-metadata">Enabling
        /// metadata in recommendations for a recommender</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public Dictionary<string, List<string>> MetadataColumns
        {
            get { return this._metadataColumns; }
            set { this._metadataColumns = value; }
        }

        // Check to see if MetadataColumns property is set
        internal bool IsSetMetadataColumns()
        {
            return this._metadataColumns != null && (this._metadataColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of results to return. The default is 25. If you are including metadata
        /// in recommendations, the maximum is 50. Otherwise, the maximum is 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Promotions. 
        /// <para>
        /// The promotions to apply to the recommendation request. A promotion defines additional
        /// business rules that apply to a configurable subset of recommended items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<Promotion> Promotions
        {
            get { return this._promotions; }
            set { this._promotions = value; }
        }

        // Check to see if Promotions property is set
        internal bool IsSetPromotions()
        {
            return this._promotions != null && (this._promotions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommenderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommender to use to get recommendations. Provide
        /// a recommender ARN if you created a Domain dataset group with a recommender for a domain
        /// use case.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RecommenderArn
        {
            get { return this._recommenderArn; }
            set { this._recommenderArn = value; }
        }

        // Check to see if RecommenderArn property is set
        internal bool IsSetRecommenderArn()
        {
            return this._recommenderArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID to provide recommendations for.
        /// </para>
        ///  
        /// <para>
        /// Required for <c>USER_PERSONALIZATION</c> recipe type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}