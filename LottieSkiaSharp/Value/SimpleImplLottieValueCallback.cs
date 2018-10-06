﻿//   Copyright 2018 yinyue200.com

//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
namespace LottieUWP.Value
{
    internal class SimpleImplLottieValueCallback<T> : LottieValueCallback<T>
    {
        private readonly SimpleLottieValueCallback<T> _callback;

        public SimpleImplLottieValueCallback(SimpleLottieValueCallback<T> callback)
        {
            _callback = callback;
        }

        public override T GetValue(LottieFrameInfo<T> frameInfo)
        {
            if(_callback != null)
                return _callback.Invoke(frameInfo);
            return default(T);
        }
    }
}