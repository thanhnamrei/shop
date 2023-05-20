import { Text } from '@/components/text';
import Login from '@/features/login';
import PublicLayout from '@/layouts/public-layout';

const View = () => {
  return (
    <PublicLayout>
      {/* <Text>Login Page</Text> */}
      <Login />
    </PublicLayout>
  );
};
export default View;
