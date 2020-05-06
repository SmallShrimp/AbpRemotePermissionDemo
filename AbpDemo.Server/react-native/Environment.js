const ENV = {
  dev: {
    apiUrl: 'http://localhost:44349',
    oAuthConfig: {
      issuer: 'http://localhost:44349',
      clientId: 'Server_App',
      clientSecret: '1q2w3e*',
      scope: 'Server',
    },
    localization: {
      defaultResourceName: 'Server',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44349',
    oAuthConfig: {
      issuer: 'http://localhost:44349',
      clientId: 'Server_App',
      clientSecret: '1q2w3e*',
      scope: 'Server',
    },
    localization: {
      defaultResourceName: 'Server',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
