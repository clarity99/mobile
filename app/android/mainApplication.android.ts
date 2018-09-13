import { ServiceContainer } from '../../services/serviceContainer';

@JavaProxy('com.tns.MainApplication')
export class MainApplication extends android.app.Application {
    serviceContainer: ServiceContainer;

    public onCreate(): void {
        super.onCreate();

        // At this point modules have already been initialized

        // Enter custom initialization code here
        this.serviceContainer = new ServiceContainer();
        this.serviceContainer.init();
    }

    public attachBaseContext(baseContext: android.content.Context) {
        super.attachBaseContext(baseContext);

        // This code enables MultiDex support for the application (if needed)
        // android.support.multidex.MultiDex.install(this);
    }
}