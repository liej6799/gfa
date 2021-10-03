import { Environment } from '@abp/ng.core';

const baseUrl = 'https://gfaweb.liej6799dev.xyz';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'gfa_web',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://gfaapi.liej6799dev.xyz',
    redirectUri: baseUrl,
    clientId: 'gfa_web_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone gfa_web',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://gfaapi.liej6799dev.xyz',
      rootNamespace: 'gfa_web',
    },
  },
} as Environment;
