const ENV = {
  dev: {
    apiUrl: 'http://localhost:44311',
    oAuthConfig: {
      issuer: 'http://localhost:44311',
      clientId: 'ClientApp_App',
      clientSecret: '1q2w3e*',
      scope: 'ClientApp',
    },
    localization: {
      defaultResourceName: 'ClientApp',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44311',
    oAuthConfig: {
      issuer: 'http://localhost:44311',
      clientId: 'ClientApp_App',
      clientSecret: '1q2w3e*',
      scope: 'ClientApp',
    },
    localization: {
      defaultResourceName: 'ClientApp',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
