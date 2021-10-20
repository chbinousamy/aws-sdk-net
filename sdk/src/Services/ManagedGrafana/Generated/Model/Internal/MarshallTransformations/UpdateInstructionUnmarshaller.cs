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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateInstruction Object
    /// </summary>  
    public class UpdateInstructionUnmarshaller : IUnmarshaller<UpdateInstruction, XmlUnmarshallerContext>, IUnmarshaller<UpdateInstruction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UpdateInstruction IUnmarshaller<UpdateInstruction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UpdateInstruction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UpdateInstruction unmarshalledObject = new UpdateInstruction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("users", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<User, UserUnmarshaller>(UserUnmarshaller.Instance);
                    unmarshalledObject.Users = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UpdateInstructionUnmarshaller _instance = new UpdateInstructionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInstructionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}