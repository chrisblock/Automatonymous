// Copyright 2011-2013 Chris Patterson, Dru Sellers
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Automatonymous.Activities
{
    using System;
    using System.Linq.Expressions;


    public class CallActivity<TInstance> :
        ActionActivity<TInstance>
    {
        readonly Expression<Action<TInstance>> _expression;

        public CallActivity(Expression<Action<TInstance>> expression)
            : base(expression.Compile())
        {
            _expression = expression;
        }

        public Expression<Action<TInstance>> Expression
        {
            get { return _expression; }
        }
    }


    public class CallActivity<TInstance, TData> :
        ActionActivity<TInstance, TData>
    {
        readonly Expression<Action<TInstance, TData>> _expression;

        public CallActivity(Expression<Action<TInstance, TData>> expression)
            : base(expression.Compile())
        {
            _expression = expression;
        }

        public Expression<Action<TInstance, TData>> Expression
        {
            get { return _expression; }
        }
    }
}