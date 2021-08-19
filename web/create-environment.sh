#!/bin/bash
resourceGroup="gfa"
location="southeastasia"

az group create -l $location -n $resourceGroup

# create database server
sqlServerName="gfadbserver"
username="liej6799"
password="4SeeFLV3FKLphSQGw526PJbnQ3PdHKTuURHUN"
az sql server create -l $location -g $resourceGroup -n $sqlServerName -u $username -p $password

az sql server firewall-rule create -g $resourceGroup -s $sqlServerName -n Azure --start-ip-address 0.0.0.0 --end-ip-address 0.0.0.0

# create database
sqlName="gfadb"

az sql db update -g $resourceGroup -s $sqlServerName -n $sqlName -e GeneralPurpose -f Gen5 -c 1 --compute-model "Serverless" --backup-storage-redundancy Local

# create app service
appServicePlan="gfaplan"
az appservice plan create -n $appServicePlan -g $resourceGroup -l $location --sku Free

appService="gfa-api"
az webapp create -g $resourceGroup -p $appServicePlan -n $appService