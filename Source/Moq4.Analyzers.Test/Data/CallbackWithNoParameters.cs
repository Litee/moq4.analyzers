﻿using Moq;

namespace CallbackWithNoParameters
{
    interface IMyService
    {
        int Do(string s);
    }

    class MyUnitTests
    {
        void MyTest()
        {
            var mock = new Mock<IMyService>();
            mock.Setup(x => x.Do(It.IsAny<string>())).Callback(() => { });
        }
    }
}