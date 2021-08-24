import { Environment } from '@abp/ng.core';

const baseUrl = 'https://api.gfaweb.xyz';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'gfa_web',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://api.gfaweb.xyz',
    redirectUri: baseUrl,
    clientId: 'gfa_web_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone gfa_web',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://api.gfaweb.xyz',
      rootNamespace: 'gfa_web',
    },
  },
} as Environment;
