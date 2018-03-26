# PaymentWindow
The FarPay PaymentWindow, is a secured payment window, that encapsulates all payment instruments, that are available in your FarPay subscription, enable your existing or new customers to create an payment instrument as well as starting a recurring payment flow.

## Scope
This is a description of how to configure the payment window in your domain.

## Terms
There are a couple of terms, that are in play, when running the Payment Window endpoint.


| Term      | Description |  Available from |
| :---      | :----       |            ---: |
| Order API | The order is placed from your business domain system, initiating an onboarding process | [Order](https://github.com/FarPay/ApiDoc/blob/master/Orders.md) and [Swagger](https://api.farpay.io/swagger/ui/index#/Orders) |
| Payment Window | An url, that the user is forwarded to, when the payment information is to be set. | [Payment Window](https://app.farpay.io/paymentWindow)
| Order     | The order, that is placed from the your business/domain system, to the FarPay Order API endpoint.| |
| OrderResponse | The response, holding the ``OrderToken``, ``ExternalID`` and ``PaymentWindowUrl``| See the [Order] details |
# Use-Case
A scenario, where a user is about to create an payment instrument, using a card. Remark, that a recurring agreement can be based on a MobilePay, Card, Betalingsservice or Leverandørserivce. The optional first-off payments can be handled by MobilePay or Card as seperate payments. For Betalingsservice and Leverandørservice, the initial payments can be merged with the subsequent monthly payments.

**UseCaseDiagram**




