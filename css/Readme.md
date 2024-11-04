# Custom CSS

The payment window can be branded to match your company's visual identity, by incorporating colors and logo.
This is done by overriding the default CSS with your own CSS file, and the file is cascaded onto the payment-window CSS.

## Images
The images, that are used, are standard images, such as the back button, cancel button, and the hamburger menu button, etc.
You have the option to override the image, by linking to own resources, and load it on the fly.
```css

    #top .top-logo {
        background: url('data:image/png;base64,iVBORw0KGgoAAAANSU.....==') no-repeat center;
    background-size: 199px 29px;
    height: 29px;
    margin-top: 23px;
    }
```
Remember, that this will slow down the duration of the page, load since the image caching is not available.

## Basic terms
The terms that can be customized are:

| **Element**                 | **Description**                                                                                                       |
|-----------------------------|-----------------------------------------------------------------------------------------------------------------------|
| `body`                      | body element, containing the backgrgound color                                                                        |
| `#top`                      | background color of the top of the page, that also contains the logo                                                  |
| `#top .back-btn`            | back button background:image: url(...)                                                                                |
| `#top .cancel-btn`          | cancel button background:image: url(...)                                                                              |
| `#top .menu-btn .menu-icon` | menu button background:image: url(...) this is the hamburger logo                                                     |
| `#top .top-logo`            | background:image: url(...);                                                                                           |
| `.pink-color`               | <font color="e83f6f">color: #e83f6f; </font> This color is used to express concerns, such as reject and cancel events |
| `#top .top-logo img`        | reference to a logo, or `display: none`, since you have embedded the login in the css.                                |
| `a`                         | anchor color - e.g. links to terms and conditions within the payment window.                                          |



## The Form

| **Element**                              | **Description**                        |
|------------------------------------------|----------------------------------------|
| `form .form-group.has-border:before`     | set background color                   |
| `.switch.switch input:checked + .slider` | set the background color of the slider |


## The ribbon

| **Element**                      | **Description**                                                      |
|----------------------------------|----------------------------------------------------------------------|
| `.screen-ribbon.reminder-ribbon` | When the ribbon is used, it should stand out with an alerting color. |


## Reminder
Funfact - we name it the metro, since it is a process diagram, that is displayed on the screen, just as a typical metro map.

| **Element**                                                | **Description**                                                                                              |
|------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| `.reminder-metro .reminder-item .metro-line `              | The line                                                                                                     |
| `reminder-metro .reminder-item .metro-line:before`         | an item on the metro-line                                                                                    |
| `.reminder-metro .reminder-item.active .metro-line:before` | The current state of the process, the current position on the metroline, that should be slightly highlighed. |



#Full example

```css
/* ---------------------------
 BASIC
 --------------------------- */
 body {
    background: #eef3f6 !important;
  }
  #top {
    background: #005a95 !important;
  }
  #top .back-btn {
    background-image: url('./../v2/assets/img/icons/icon-back-white.png') !important;
  }
  #top .cancel-btn {
    background-image: url('./../v2/assets/img/icons/icon-close-white.png') !important;
  }
  #top .menu-btn .menu-icon {
    background-image: url('./../v2/assets/img/icons/icon-menu-burger-white.png') !important;
  }
  #top .menu-btn span {
    color: #fff;
  }
  #top .top-logo {
    background: url('data:image/png;base64,iVBORw....==') no-repeat center;
    background-size: 199px 29px;
    height: 29px;
    margin-top: 23px;
  }
  #top .top-logo img {
    display: none;
  }
  a {
    color: #009de5 !important;
  }
  .btn.do-pay-btn, .btn.choose-method, .btn.btn-continue, .btn.btn-blue {
    background: #63ba03;
    color: #fff;
  }
  .btn.do-pay-btn:disabled, .btn.choose-method:disabled, .btn.btn-continue:disabled, .btn.btn-blue:disabled {
    background: #cdcccc;
    opacity: 1;
    pointer-events: none;
  }
  .btn.do-pay-btn:hover, .btn.choose-method:hover, .btn.btn-continue:hover, .btn.btn-blue:hover, .btn.do-pay-btn:focus, .btn.choose-method:focus, .btn.btn-continue:focus, .btn.btn-blue:focus {
    background: #56a103;
  }
  .app-menu .menu-lang-switch ul li a.active {
    border-color: #009de5 !important;
  }
  .pink-color {
    color: #e83f6f !important;
  }
  /* ---------------------------
   FORM
   --------------------------- */
  form .form-group.has-border:before {
    background: #009de5 !important;
  }
  .switch.switch input:checked + .slider {
    background: #009de5 !important;
    border-color: #009de5 !important;
  }
  .table tr {
    border-color: #eef3f6 !important;
  }
  /* ---------------------------
   RIBBON REMINDER
   --------------------------- */
  .screen-ribbon.reminder-ribbon {
    background: #e83f6f !important;
  }
  /* ---------------------------
   METRO REMINDER
   --------------------------- */
  .reminder-metro .reminder-item .metro-line {
    background: #009de5 !important;
  }
  .reminder-metro .reminder-item .metro-line:before {
    border-color: #009de5 !important;
  }
  .reminder-metro .reminder-item.active .metro-line:before {
    background: #009de5 !important;
  }
  /* ---------------------------
   INVOICE
   --------------------------- */
   ```