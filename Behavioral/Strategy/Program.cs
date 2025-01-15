// Strategy design patttern defines a family of algorithms, encapsulates each one, and makes them interchangeable.

using Strategy.Context;
using Strategy.Strategies;

decimal transferAmount = 1000;

var paymentContext = new PaymentContext();

paymentContext.SetPaymentStrategy(new ApplePayPayment("test@icloud.com"));
paymentContext.ExecutePayment(transferAmount);

paymentContext.SetPaymentStrategy(new GooglePayPayment("0888888888"));
paymentContext.ExecutePayment(transferAmount);

paymentContext.SetPaymentStrategy(new PayPalPayment("test@mail.com"));
paymentContext.ExecutePayment(transferAmount);

paymentContext.SetPaymentStrategy(new CreditCardPayment("1234-5678-9123-4567", new DateTime(2026, 2, 10), "891"));
paymentContext.ExecutePayment(transferAmount);
