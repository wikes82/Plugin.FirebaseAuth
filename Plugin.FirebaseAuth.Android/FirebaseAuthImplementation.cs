﻿using System;
using System.Threading.Tasks;
using Firebase;

namespace Plugin.FirebaseAuth
{
    public class FirebaseAuthImplementation : IFirebaseAuth
    {
        public IEmailAuthProvider EmailAuthProvider { get; } = new EmailAuthProviderWrapper();

        public IGoogleAuthProvider GoogleAuthProvider { get; } = new GoogleAuthProviderWrapper();

        public IFacebookAuthProvider FacebookAuthProvider { get; } = new FacebookAuthProviderWrapper();

        public ITwitterAuthProvider TwitterAuthProvider { get; } = new TwitterAuthProviderWrapper();

        public IGitHubAuthProvider GitHubAuthProvider { get; } = new GitHubAuthProviderWrapper();

        public IPhoneAuthProvider PhoneAuthProvider { get; } = new PhoneAuthProviderWrapper();

        public IOAuthProvider OAuthProvider { get; } = new OAuthProviderWrapper();

        public IPlayGamesAuthProvider PlayGamesAuthProvider { get; } = new PlayGamesAuthProviderWrapper();

        public IAuth Instance
        {
            get
            {
                return new AuthWrapper(Firebase.Auth.FirebaseAuth.Instance);
            }
        }

        public IAuth GetInstance(string appName)
        {
            var app = FirebaseApp.GetInstance(appName);
            return new AuthWrapper(Firebase.Auth.FirebaseAuth.GetInstance(app));
        }
    }
}
