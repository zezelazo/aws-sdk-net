/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ApplicationAutoScaling.Model;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Interface for accessing ApplicationAutoScaling
    ///
    /// Application Auto Scaling is a general purpose Auto Scaling service for supported elastic
    /// AWS resources. With Application Auto Scaling, you can automatically scale your AWS
    /// resources, with an experience similar to that of Amazon EC2 Auto Scaling.
    /// 
    ///  <note> 
    /// <para>
    /// At this time, Application Auto Scaling only supports scaling Amazon ECS services.
    /// </para>
    ///  </note> 
    /// <para>
    /// For example, you can use Application Auto Scaling to accomplish the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Define scaling policies for automatically adjusting your application’s resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale your resources in response to CloudWatch alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View history of your scaling events 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonApplicationAutoScaling : IDisposable
    {

        
        #region  DeleteScalingPolicy


        /// <summary>
        /// Deletes an Application Auto Scaling scaling policy that was previously created. If
        /// you are no longer using a scaling policy, you can delete it with this operation.
        /// 
        ///  
        /// <para>
        /// Deleting a policy deletes the underlying alarm action, but does not delete the CloudWatch
        /// alarm, even if it no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// To create a new scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteScalingPolicy service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// can not be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterScalableTarget


        /// <summary>
        /// Deregisters a scalable target that was previously registered. If you are no longer
        /// using a scalable target, you can delete it with this operation. When you deregister
        /// a scalable target, all of the scaling policies that are associated with that scalable
        /// target are deleted.
        /// 
        ///  
        /// <para>
        /// To create a new scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget service method.</param>
        /// 
        /// <returns>The response from the DeregisterScalableTarget service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// can not be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalableTargets


        /// <summary>
        /// Provides descriptive information for scalable targets with a specified service namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results in a service namespace with the <code>ResourceIds</code>
        /// and <code>ScalableDimension</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// To create a new scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
        /// If you are no longer using a scalable target, you can deregister it with <a>DeregisterScalableTarget</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeScalableTargets service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalingActivities


        /// <summary>
        /// Provides descriptive information for scaling activities with a specified service namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results in a service namespace with the <code>ResourceId</code>
        /// and <code>ScalableDimension</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// Scaling activities are triggered by CloudWatch alarms that are associated with scaling
        /// policies. To view the existing scaling policies for a service namespace, see <a>DescribeScalingPolicies</a>.
        /// To create a new scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalingPolicies


        /// <summary>
        /// Provides descriptive information for scaling policies with a specified service namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results in a service namespace with the <code>ResourceId</code>,
        /// <code>ScalableDimension</code>, and <code>PolicyNames</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// To create a new scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
        /// If you are no longer using a scaling policy, you can delete it with <a>DeleteScalingPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPolicies service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.FailedResourceAccessException">
        /// Failed access to resources caused an exception. This exception currently only applies
        /// to <a>DescribeScalingPolicies</a>. It is thrown when Application Auto Scaling is unable
        /// to retrieve the alarms associated with a scaling policy due to a client error. For
        /// example, if the role ARN specified for a scalable target does not have the proper
        /// permissions to call the CloudWatch <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarms.html">DescribeAlarms</a>
        /// API operation on behalf of your account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a policy for an existing Application Auto Scaling scalable target.
        /// Each scalable target is identified by service namespace, a resource ID, and a scalable
        /// dimension, and a scaling policy applies to a scalable target that is identified by
        /// those three attributes. You cannot create a scaling policy without first registering
        /// a scalable target with <a>RegisterScalableTarget</a>.
        /// 
        ///  
        /// <para>
        /// To update an existing policy, use the existing policy name and set the parameters
        /// you want to change. Any existing parameter not changed in an update to an existing
        /// policy is not changed in this update request.
        /// </para>
        ///  
        /// <para>
        /// You can view the existing scaling policies for a service namespace with <a>DescribeScalingPolicies</a>.
        /// If you are no longer using a scaling policy, you can delete it with <a>DeleteScalingPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// Your account exceeded a limit. This exception is thrown when a per-account resource
        /// limit is exceeded. Application Auto Scaling has a limit of 40 scalable targets per
        /// account for Amazon ECS services, 50 scaling policies per scalable target, and 20 step
        /// adjustments per step scaling policy.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// can not be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterScalableTarget


        /// <summary>
        /// Registers or updates a scalable target. A scalable target is a resource that can be
        /// scaled up or down with Application Auto Scaling. Once you have registered a scalable
        /// target, you can use this command to update the minimum and maximum values for your
        /// scalable dimension.
        /// 
        ///  <note> 
        /// <para>
        /// At this time, Application Auto Scaling only supports scaling Amazon ECS services.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you register a scalable target with Application Auto Scaling, you can create
        /// and apply scaling policies to it with <a>PutScalingPolicy</a>. You can view the existing
        /// scaling policies for a service namespace with <a>DescribeScalableTargets</a>. If you
        /// are no longer using a scalable target, you can deregister it with <a>DeregisterScalableTarget</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget service method.</param>
        /// 
        /// <returns>The response from the RegisterScalableTarget service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// Your account exceeded a limit. This exception is thrown when a per-account resource
        /// limit is exceeded. Application Auto Scaling has a limit of 40 scalable targets per
        /// account for Amazon ECS services, 50 scaling policies per scalable target, and 20 step
        /// adjustments per step scaling policy.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterScalableTargetResponse> RegisterScalableTargetAsync(RegisterScalableTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}