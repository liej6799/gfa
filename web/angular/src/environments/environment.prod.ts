import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'gfa_web',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44399',
    redirectUri: baseUrl,
    clientId: 'gfa_web_App',
    responseType: 'code',
    scope: 'offline_access gfa_web',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44399',
      rootNamespace: 'gfa_web',
    },
  },
} as Environment;
