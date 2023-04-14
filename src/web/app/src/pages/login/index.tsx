import { Text } from '@/components/text';
import Login from '@/features/login';
import PublicLayout from '@/layouts/PublicLayout';

const View = () => {
  return (
    <PublicLayout>
      {/* <Text>Login Page</Text> */}
      <Login />
    </PublicLayout>
  );
};
export default View;
