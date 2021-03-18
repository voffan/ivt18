using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace Computers
{
    public sealed class Auth
    {
        private readonly FirebaseAuthClient client;
        private User user;

        private Auth()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAgrThiqUBK1tqRhwq2rDyIibUHjB081KM",
                AuthDomain = "computersapp-b46af.firebaseapp.com",            
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("Computers")
            };
            client = new FirebaseAuthClient(config);
            user = client.User;
        }

        private static Auth instance;
        public static Auth Shared
        {
            get
            {
                if (instance == null)
                {
                    instance = new Auth();
                }
                return instance;
            }
        }

        public bool SignedIn
        {
            get { return user != null; }
        }

        public async Task<FirebaseAuthException> RegisterAsync(string email, string password, string name)
        {
            try
            {
                UserCredential userCredentials = await client.CreateUserWithEmailAndPasswordAsync(email, password, name);
                user = userCredentials.User;
            } 
            catch (FirebaseAuthException e)
            {
                return e;
            }
            return null;
        }

        public async Task<FirebaseAuthException> SignInAsync(string email, string password)
        {
            try
            {
                UserCredential userCredentials = await client.SignInWithEmailAndPasswordAsync(email, password);
                user = userCredentials.User;
            } 
            catch (FirebaseAuthException e)
            {
                return e;
            }
            return null;
        }

        public async Task SignOutAsync()
        {
            await client.SignOutAsync();
            user = null;
        }
    }
}
