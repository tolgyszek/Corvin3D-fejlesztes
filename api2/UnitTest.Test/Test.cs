﻿using api2;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.Generic;
using System.ComponentModel;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Membership;
using Hotcakes.CommerceDTO.v1.Orders;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System;

namespace UnitTest.Test
{
    public class Form3Test
    {
        private Form3 _form3;

        [SetUp]
        public void Setup()
        {
            _form3 = new Form3();
        }

        [Test]
        public void Test_ValidateFirstName_ShouldCancelEvent_ForEmptyName()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxFirst.Text = ""; // Üres név beállítása

            // Act
            _form3.textBoxFirst_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsTrue(cancelEventArgs.Cancel);
        }

        [Test]
        public void Test_ValidateFirstName_ShouldAllowValidFirstName()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxFirst.Text = "János"; // Érvényes keresztnév beállítása

            // Act
            _form3.textBoxFirst_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsFalse(cancelEventArgs.Cancel, "Valid first name should not cancel the event.");
        }

        [Test]
        public void Test_ValidateLastName_ShouldCancelEvent_ForEmptyName()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxLast.Text = ""; // Üres vezetéknév beállítása

            // Act
            _form3.textBoxLast_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsTrue(cancelEventArgs.Cancel);
        }

        [Test]
        public void Test_ValidateLastName_ShouldAllowValidLastName()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxLast.Text = "Kovács"; // Érvényes vezetéknév beállítása

            // Act
            _form3.textBoxLast_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsFalse(cancelEventArgs.Cancel, "Valid last name should not cancel the event.");
        }

        [Test]
        public void Test_ValidateEmail_ShouldReturnTrue_ForValidEmail()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxEmail.Text = "test@example.com"; // Érvényes e-mail beállítása

            // Act
            _form3.textBoxEmail_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsFalse(cancelEventArgs.Cancel, "Valid email should not cancel the event.");
        }

        [Test]
        public void Test_ValidateEmail_ShouldReturnFalse_ForEmptyEmail()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxEmail.Text = ""; // Üres e-mail beállítása

            // Act
            _form3.textBoxEmail_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsTrue(cancelEventArgs.Cancel, "Empty email should cancel the event.");
        }

        [Test]
        public void Test_ValidateEmail_ShouldReturnFalse_ForEmailWithoutAtSymbol()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxEmail.Text = "testdomainexample.com"; // Érvénytelen e-mail beállítása

            // Act
            _form3.textBoxEmail_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsTrue(cancelEventArgs.Cancel, "Invalid email should cancel the event.");
        }

        [Test]
        public void Test_ValidateEmail_ShouldReturnFalse_ForEmailWithoutDot()
        {
            // Arrange
            var cancelEventArgs = new CancelEventArgs();
            _form3.textBoxEmail.Text = "testemail@example"; // Érvénytelen e-mail beállítása

            // Act
            _form3.textBoxEmail_Validating(null, cancelEventArgs);

            // Assert
            ClassicAssert.IsTrue(cancelEventArgs.Cancel, "Invalid email should cancel the event.");
        }

        [Test]
        public void Test_LoadContact_ShouldFillForm_WithValidData()
        {
            // Arrange
            var customer = new ugyfel
            {
                vezeteknev = "Teszt",
                keresztnev = "Elek",
                email = "test.elek@example.com",
                telepules = "Budapest",
                cim = "Fő utca 1",
            };

            _form3 = new Form3();

            // Act
            _form3.LoadContact(customer);

            // Assert
            ClassicAssert.AreEqual(customer.vezeteknev, _form3.textBoxLast.Text);
            ClassicAssert.AreEqual(customer.keresztnev, _form3.textBoxFirst.Text);
            ClassicAssert.AreEqual(customer.email, _form3.textBoxEmail.Text);
            ClassicAssert.AreEqual(customer.telepules, _form3.textBoxCity.Text);
            ClassicAssert.AreEqual(customer.cim, _form3.textBoxAddress.Text);
        }

        [Test]
        public void Test_LoadContact_ShouldClearForm_WithNullData()
        {
            // Arrange
            _form3 = new Form3();

            // Act
            _form3.LoadContact(null);

            // Assert
            ClassicAssert.AreEqual(string.Empty, _form3.textBoxLast.Text);
            ClassicAssert.AreEqual(string.Empty, _form3.textBoxFirst.Text);
            ClassicAssert.AreEqual(string.Empty, _form3.textBoxEmail.Text);
            ClassicAssert.AreEqual(string.Empty, _form3.textBoxCity.Text);
            ClassicAssert.AreEqual(string.Empty, _form3.textBoxAddress.Text);
        }
    }
    public class Form1Test
    {
        private Form1 _form1;

        [SetUp]
        public void Setup()
        {
            _form1 = new Form1();
        }

        [Test]
        public void Test_SearchButtonClick_ShouldFilterCustomersCorrectly()
        {
            // Arrange
            _form1.textBoxSearch.Text = "Smith"; // Teszt keresési szöveg beállítása

            // Act
            _form1.buttonSearch_Click(null, null);

            // Assert
            var filteredCustomers = _form1.ugyfelBindingSource.List.Cast<ugyfel>().ToList();

            // Ellenőrizzük, hogy a keresésnek megfelelő ügyfelek vannak-e a listában
            ClassicAssert.IsTrue(filteredCustomers.All(c => c.vezeteknev.Contains("Smith")));

            // Ha az összes ügyfél megfelel a szűrésnek, akkor a DataGridView frissült
            ClassicAssert.AreEqual(filteredCustomers.Count, _form1.dataGridView1.RowCount);
        }
        /*
        [Test]
        public void Test_DeleteContact_ShouldDisplayMessage_WhenUserHasOrders()
        {
            // Arrange
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);

            // Mivel az `apihivas` egy proxyt hoz létre, amelyet nem lehet ellenőrizni
            // a tesztben, ajánlott lenne ezt a funkciót felcserélni egy interfész használatára, 
            // amelynek a létrehozása könnyebben tesztelhető lenne.
            // Itt az eredeti API-t simuláló mock API-t használunk a teszteléshez.

            var mockApi = new Mock<Api>(MockBehavior.Strict);

            // Az API hívásokat megfelelő válaszokkal ellátjuk

            mockApi.Setup(x => x.OrdersFindAll()).Returns(new ApiResponse<List<OrderSnapshotDTO>>
            {
                Content = new List<OrderSnapshotDTO>
                {
                    new OrderSnapshotDTO { UserID = "123" },  // Tesztelés céljából adjunk hozzá egy rendelést
                    new OrderSnapshotDTO { UserID = "456" }
                }
            });

            // API-hívás cseréje a mockApi-val

            _form1.apihivas = () => mockApi.Object;

            // Act
            _form1.DeleteContact(args);

            // Assert
            ClassicAssert.AreEqual("A felhasználó nem törölhető, mert van rendelése", _form1.MessageBoxText);
        }

        [Test]
        public void Test_DeleteContact_ShouldCallApiToDeleteUser_WhenUserHasNoOrders()
        {
            // Arrange
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);

            var mockApi = new Mock<Api>(MockBehavior.Strict);

            mockApi.Setup(x => x.OrdersFindAll()).Returns(new ApiResponse<List<OrderSnapshotDTO>>
            {
                Content = new List<OrderSnapshotDTO>
                {
                    new OrderSnapshotDTO { UserID = "456" }  // A felhasználónak nincsenek rendelései
                }
            });

            mockApi.Setup(x => x.CustomerAccountsDelete(It.IsAny<string>()))
                .Returns(new ApiResponse<bool> { Content = true });

            _form1.apihivas = () => mockApi.Object;

            // Act
            _form1.DeleteContact(args);

            // Assert
            mockApi.Verify(x => x.CustomerAccountsDelete(It.IsAny<string>()), Times.Once);
            ClassicAssert.AreEqual("A felhasználó sikeresen törölve", _form1.MessageBoxText);
        }*/
    }
}