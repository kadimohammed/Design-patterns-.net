using I__Strategy;




// Création service avec la strategie denvoi par e-mail
var service = new ServiceMessage(new EmailMessageStrategy());
service.Envoyer("contact@exemple.com", "Bonjour par email!");

// changer la strategie pour envoyer un SMS
service.ChangerStrategie(new SmsMessageStrategy());
service.Envoyer("1234567890", "Bonjour par SMS!");

// changer la strategie pour envoyer une notification push
service.ChangerStrategie(new PushNotificationMessageStrategy());
service.Envoyer("user123", "Bonjour par notification push!");