export const environment = {
  production: true,
  application: {
    name: 'Server',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44349',
    clientId: 'Server_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'Server',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44349'
    }
  },
  localization: {
    defaultResourceName: 'Server'
  }
};
