// The Adapter Pattern is a structural design pattern used to bridge the gap between two incompatible interfaces. It acts as a translator that allows objects with different interfaces to work together. This is particularly useful when you want to integrate a class or library into your system but the interface of the class/library does not match the one your code expects.

using Adapter.Adapters;
using Adapter.Contracts;
using Adapter.Services;
using Adapter.ThirdParty;

var thirdPartyPayment = new ThirdPartyPayment();
IPaymentProcessor adapter = new PaymentAdapter(thirdPartyPayment);

var paymentService = new PaymentService(adapter);
paymentService.Pay(100);