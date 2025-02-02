﻿using System;
using Bit.Core.Services;
using Bit.Core.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace Bit.Core.Test.Services
{
    public class NotificationsApiPushNotificationServiceTests
    {
        private readonly NotificationsApiPushNotificationService _sut;

        private readonly GlobalSettings _globalSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<NotificationsApiPushNotificationService> _logger;

        public NotificationsApiPushNotificationServiceTests()
        {
            _globalSettings = new GlobalSettings();
            _httpContextAccessor = Substitute.For<IHttpContextAccessor>();
            _logger = Substitute.For<ILogger<NotificationsApiPushNotificationService>>();

            _sut = new NotificationsApiPushNotificationService(
                _globalSettings,
                _httpContextAccessor,
                _logger
            );
        }

        // Remove this test when we add actual tests. It only proves that
        // we've properly constructed the system under test.
        [Fact(Skip = "Needs additional work")]
        public void ServiceExists()
        {
            Assert.NotNull(_sut);
        }
    }
}
