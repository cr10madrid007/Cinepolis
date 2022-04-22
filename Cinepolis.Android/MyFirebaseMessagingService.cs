using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Media;
using Android.Util;
using Firebase.Messaging;
using Xamarin.Essentials;
using Cinepolis.Clases;
using Cinepolis.vMenu;

namespace Cinepolis.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";
        AndroidNotificationManager androidNotification = new AndroidNotificationManager();
        public override void OnMessageReceived(RemoteMessage message)
        {

            IDictionary<string, string> MensajeData = message.Data;

            string Titulo = MensajeData["notiTitle"];
            string SubTitulo = MensajeData["notiBody"];

            androidNotification.CrearNotificacionLocal(Titulo, SubTitulo);
        }
        public override void OnNewToken(string token)
        {
            base.OnNewToken(token);

            Preferences.Set("TokenFirebase", token);
            sedRegisterToken(token);
        }
        public void sedRegisterToken(string token)
        {
            var direc = new Clases.addClass();
            direc.registrar(token);


        }
    }
}