﻿using System;

using App2.ViewModels;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App2.Tests.MSTest
{
    // TODO WTS: Add appropriate tests
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // TODO WTS: Add tests for functionality you add to MainViewModel.
        [TestMethod]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to MasterDetailViewModel.
        [TestMethod]
        public void TestMasterDetailViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MasterDetailViewModel();
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to SettingsViewModel.
        [TestMethod]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.IsNotNull(vm);
        }
    }
}
